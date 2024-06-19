using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VerchoturcevQuest{
    public partial class FormTest : Form
    {
        ControllerTest _controllerTest;
        int fpminheight;
        int formminheight;
        Dictionary<Control, Answer> _map = new Dictionary<Control, Answer>();
        public FormTest(ControllerTest controllerTest)
        {
            _controllerTest = controllerTest;
            InitializeComponent();
            fpminheight = answersPanel.Height;
            formminheight = Height;
            DisplayNextQuestion();
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                DialogResult closeMsg = MessageBox.Show("Вы действительно хотите отменить тест?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (closeMsg != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void DisplayNextQuestion()
        {
            if (_controllerTest.CurIndex >= _controllerTest.GetMaxIndex())
            {
                MessageBox.Show(_controllerTest.Correct + " правильных ответов из " + _controllerTest.GetMaxIndex());
                DialogResult = DialogResult.OK;
                return;
            }
            answersPanel.Controls.Clear();
            _map.Clear();
            Question question = _controllerTest.GetNextQuestion();
            questionText.Text = question.Text;
            questionNum.Text = "Вопрос " + _controllerTest.CurIndex + @"/" + _controllerTest.GetMaxIndex();
            switch (question.GetQType())
            {
                case QuestionType.QT_Single:
                    foreach(Answer answer in question.GetOptions())
                    {
                        RadioButton radioButton = new RadioButton();
                        radioButton.Text = answer.Text;
                        int heightadd = (TextRenderer.MeasureText(answer.Text, radioButton.Font).Width + 20)/answersPanel.Width;
                        radioButton.Width = answersPanel.Width;
                        radioButton.Height += radioButton.Height*heightadd;
                        _map.Add(radioButton, answer);
                        answersPanel.Controls.Add(radioButton);
                    }
                    break;
                case QuestionType.QT_Multiple:
                    foreach (Answer answer in question.GetOptions())
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = answer.Text;
                        int heightadd = (TextRenderer.MeasureText(answer.Text, checkBox.Font).Width + 20) / answersPanel.Width;
                        checkBox.Width = answersPanel.Width;
                        checkBox.Height += checkBox.Height * heightadd;
                        _map.Add(checkBox, answer);
                        answersPanel.Controls.Add(checkBox);
                    }
                    break;
                case QuestionType.QT_Free:
                        TextBox textBox = new TextBox();
                        _map.Add(textBox, question.GetOptions()[0]);
                        answersPanel.Controls.Add(textBox);
                    break;
            }
            int height = answersPanel.Padding.Vertical;
            foreach(Control control in answersPanel.Controls)
            {
                height += control.Height + answersPanel.Margin.Vertical;
            }
            if (height > fpminheight)
            {
                Height = Height + height - answersPanel.Height;
            }
            else
            {
                Height = formminheight;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (_controllerTest.CurQuestion.GetQType())
            {
                case QuestionType.QT_Single:
                    bool ok = false;
                    foreach (KeyValuePair<Control, Answer> keyValuePair in _map)
                    {
                        RadioButton radioButton = (RadioButton)keyValuePair.Key;
                        if (radioButton.Checked)
                        {
                            _controllerTest.Answer(keyValuePair.Value);
                            ok = true;
                            break;
                        }
                    }
                    if (!ok)
                    {
                        MessageBox.Show("Выберите ответ");
                        return;
                    }
                    break;
                case QuestionType.QT_Multiple:
                    List<Answer> answers = new List<Answer>();
                    foreach (KeyValuePair<Control, Answer> keyValuePair in _map)
                    {
                        CheckBox checkBox = (CheckBox)keyValuePair.Key;
                        if (checkBox.Checked)
                        {
                            answers.Add(keyValuePair.Value);
                        }
                    }
                    if (answers.Count < 1)
                    {
                        MessageBox.Show("Выберите ответ(ы)");
                        return;
                    }
                    else
                    {
                        _controllerTest.Answer(answers);
                    }
                    break;
                case QuestionType.QT_Free:
                    TextBox textBox = (TextBox)_map.Keys.First();
                    if(textBox.Text == "")
                    {
                        MessageBox.Show("Введите ответ");
                        return;
                    }
                    _controllerTest.Answer(textBox.Text);
                    break;
            }
            DisplayNextQuestion();
        }

        public TestResult GetResult()
        {
            return _controllerTest.GetResult();
        }
    }
}
