using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerchoturcevQuest{
    public partial class FormNewAnswer : Form
    {
        public FormNewAnswer()
        {
            InitializeComponent();
        }

        public bool IsCorrect()
        {
            return cb_iscorrect.Checked;
        }

        public string GetText()
        {
            return tb_text.Text;
        }

        private void FormNewAnswer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK && tb_text.Text == "")
            {
                MessageBox.Show("Введите текст ответа");
                e.Cancel = true;
            }
        }
    }
}
