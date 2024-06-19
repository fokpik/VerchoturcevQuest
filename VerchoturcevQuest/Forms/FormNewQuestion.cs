using System;
using System.Windows.Forms;

namespace VerchoturcevQuest{
    public partial class FormNewQuestion : Form
    {
        public FormNewQuestion()
        {
            InitializeComponent();
        }

        public QuestionType GetQuestionType()
        {
            if (rb_single.Checked)
                return QuestionType.QT_Single;
            if (rb_multiple.Checked)
                return QuestionType.QT_Multiple;
            if (rb_free.Checked)
                return QuestionType.QT_Free;
            throw new Exception();
        }

        public string GetText()
        {
            return tb_text.Text;
        }

        public string GetAnswer()
        {
            return tb_answer.Text;
        }

        private void FormNewQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK && (tb_text.Text == "" || (rb_free.Checked && tb_answer.Text == "")))
            {
                MessageBox.Show("Заполните все поля");
                e.Cancel = true;
            }
        }

        private void rb_free_CheckedChanged(object sender, EventArgs e)
        {
            tb_answer.Enabled = rb_free.Checked;
        }
    }
}
