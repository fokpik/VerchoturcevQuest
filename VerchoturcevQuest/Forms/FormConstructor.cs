using System;
using System.Windows.Forms;

namespace VerchoturcevQuest{
    public partial class FormConstructor : Form
    {
        ControllerConstructor _controllerConstructor;
        public FormConstructor(ControllerConstructor controllerConstructor)
        {
            _controllerConstructor = controllerConstructor;
            InitializeComponent();
            nameTB.Text = _controllerConstructor.Name;
        }

        private void NewQButton_Click(object sender, EventArgs e)
        {
            FormNewQuestion formNewQuestion = new FormNewQuestion();
            formNewQuestion.ShowDialog();
            if(formNewQuestion.DialogResult == DialogResult.OK)
            {
                switch (formNewQuestion.GetQuestionType())
                {
                    case QuestionType.QT_Single:
                        _controllerConstructor.CreateQuestionSingle(formNewQuestion.GetText());
                        break;
                    case QuestionType.QT_Multiple:
                        _controllerConstructor.CreateQuestionMultiple(formNewQuestion.GetText());
                        break;
                    case QuestionType.QT_Free:
                        _controllerConstructor.CreateQuestionFree(formNewQuestion.GetText(), formNewQuestion.GetAnswer());
                        break;
                }
                RefreshQuestionsList();
            }
        }

        private void RefreshQuestionsList()
        {
            questionsLB.Items.Clear();
            foreach(Question question in _controllerConstructor.GetQuestions())
            {
                questionsLB.Items.Add(question);
            }
        }

        private void RefreshAnswersList(Question question)
        {
            answersLB.Items.Clear();
            foreach (Answer answer in question.GetOptions())
            {
                answersLB.Items.Add(answer);
            }
        }

        private void questionsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionsLB.SelectedIndex == -1)
            {
                answersLB.Items.Clear();
                deleteQButton.Enabled = false;
                newAButton.Enabled = false;
                return;
            }

            RefreshAnswersList((Question)questionsLB.SelectedItem);
            deleteQButton.Enabled = true;

            if (((Question)questionsLB.SelectedItem).GetQType() == QuestionType.QT_Free)
            {   
                newAButton.Enabled = false;
            }
            else
            {
                newAButton.Enabled = true;
            }

        }

        private void answersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(answersLB.SelectedIndex == -1)
            {
                deleteAButton.Enabled = false;
            }

            if(((Question)questionsLB.SelectedItem).GetQType() != QuestionType.QT_Free)
            {
                deleteAButton.Enabled = true;
            }
        }

        private void deleteQButton_Click(object sender, EventArgs e)
        {
            _controllerConstructor.DeleteQuestion((Question)questionsLB.SelectedItem);
            questionsLB.SelectedIndex--;
            questionsLB.Items.RemoveAt(questionsLB.SelectedIndex + 1);
        }

        private void deleteAButton_Click(object sender, EventArgs e)
        {
            _controllerConstructor.DeleteAnswer((Question)questionsLB.SelectedItem,(Answer)answersLB.SelectedItem);
            answersLB.SelectedIndex--;
            answersLB.Items.RemoveAt(answersLB.SelectedIndex + 1);
        }

        private void newAButton_Click(object sender, EventArgs e)
        {
            FormNewAnswer formNewAnswer = new FormNewAnswer();
            formNewAnswer.ShowDialog();
            if (formNewAnswer.DialogResult == DialogResult.OK)
            {
                _controllerConstructor.CreateAnswer((Question)questionsLB.SelectedItem, formNewAnswer.GetText(), formNewAnswer.IsCorrect());
                RefreshAnswersList((Question)questionsLB.SelectedItem);
            }
        }

        private void FormConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(nameTB.Text == "")
                {
                    MessageBox.Show("Введите имя теста");
                    e.Cancel = true;
                    return;
                }
                _controllerConstructor.Name = nameTB.Text;
                if(!_controllerConstructor.CheckIntegrity())
                {
                    MessageBox.Show("Целостность теста нарушена\r\nВозможные причины: нет вопросов, один или несколько вопросов не содержат (правильных) ответов, один или несколько вопросов с одним ответом содержат несколько правильных ответов.");
                    e.Cancel = true;
                    return;
                }
            }
        }

        public Test GetTest()
        {
            return _controllerConstructor.CreateTest();
        }
    }
}
