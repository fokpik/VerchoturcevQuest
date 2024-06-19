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
    public partial class FormMain : Form
    {
        ControllerMain _controllerMain = new ControllerMain();

        public FormMain()
        {          
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            FormConstructor formConstructor = new FormConstructor(_controllerMain.CreateControllerConstructor());
            formConstructor.ShowDialog();
            if(formConstructor.DialogResult == DialogResult.OK)
            {
                Test test = formConstructor.GetTest();
                _controllerMain.SaveTest(test);
                testsList.Items.Add(test);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach (Test test in _controllerMain.GetTests())
            {
                testsList.Items.Add(test);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(testsList.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тест");
                return;
            }
            FormEnterTest formEnterTest = new FormEnterTest();
            formEnterTest.ShowDialog();
            if(formEnterTest.DialogResult == DialogResult.OK)
            {
                Test test = (Test)testsList.SelectedItem;
                FormTest formTest = new FormTest(_controllerMain.CreateControllerTest(test, formEnterTest.GetName(), formEnterTest.GetGroup()));
                formTest.ShowDialog();
                if(formTest.DialogResult == DialogResult.OK)
                {
                    TestResult testResult = formTest.GetResult();
                    _controllerMain.SaveResult(test, testResult);
                    resultsGrid.Rows.Add(testResult.StudentGroup, testResult.StudentName, testResult.Score, testResult.Date);
                }
            }
        }

        private void testsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsGrid.Rows.Clear();
            if (testsList.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
                return;
            }
            deleteButton.Enabled = true;
            Test curTest = (Test)testsList.SelectedItem;
            foreach(TestResult testResult in curTest.Results)
            {
                resultsGrid.Rows.Add(testResult.StudentGroup, testResult.StudentName, testResult.Score, testResult.Date);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult closeMsg = MessageBox.Show("Вы действительно хотите удалить этот тест?\r\nВсе связанные с ним результаты будут так же удалены.", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            {
                _controllerMain.DeleteTest((Test)testsList.SelectedItem);
                testsList.SelectedIndex--;
                testsList.Items.RemoveAt(testsList.SelectedIndex + 1);
            }
        }
    }
}
