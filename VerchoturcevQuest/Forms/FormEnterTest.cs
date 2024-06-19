using System.Windows.Forms;

namespace VerchoturcevQuest{
    public partial class FormEnterTest : Form
    {
        public FormEnterTest()
        {
            InitializeComponent();
        }

        private void FormEnterTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && (tb_name.Text == "" || tb_group.Text == ""))
            {
                e.Cancel = true;
                MessageBox.Show("Заполните все поля");
            }
        }

        public string GetName()
        {
            return tb_name.Text;
        }

        public string GetGroup()
        {
            return tb_group.Text;
        }
    }
}
