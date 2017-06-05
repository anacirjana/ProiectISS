using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;
using MyProject.Domain;
using MyProject.Controller;

namespace MyProject
{
    public partial class FormSpeaker : Form
    {
        Speaker loggedUser;
        Form prevForm;
        ControllerPapers _controllerPapers;

        public FormSpeaker(Speaker s, Form prev)
        {
            loggedUser = s;
            InitializeComponent();
            _controllerPapers = new ControllerPapers();
            LabelUsername.Text = s.Username;
            prevForm = prev;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Today < _controllerPapers.GetPaperDeadline())
            {

                OpenFileDialog op1 = new OpenFileDialog();

                op1.Multiselect = true;

                op1.ShowDialog();

                op1.Filter = "allfiles|*.doc*";

                tbPaper.Text = op1.FileName;

                int count = 0;

                string[] FName;

                foreach (string s in op1.FileNames)

                {

                    FName = s.Split('\\');
                    string ExecutableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    object path = Path.Combine(ExecutableLocation, "PaperContents/");
                    File.Copy(s, path + FName[FName.Length - 1]);

                    count++;

                }

                MessageBox.Show(Convert.ToString(count) + "Uploaded with success!");
            }
            else
            {
                MessageBox.Show("The paper uploading phase is over!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DateTime.Today < _controllerPapers.GetAbstractDeadline())
            {
                OpenFileDialog op1 = new OpenFileDialog();

                op1.Multiselect = true;

                op1.ShowDialog();

                op1.Filter = "allfiles|*.docx";

                tbPaper.Text = op1.FileName;

                int count = 0;

                string[] FName;

                foreach (string s in op1.FileNames)

                {

                    FName = s.Split('\\');
                    string ExecutableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    object path = Path.Combine(ExecutableLocation, "PaperContents/");
                    File.Copy(s, path + FName[FName.Length - 1]);

                    count++;

                }

                MessageBox.Show(Convert.ToString(count) + "Uploaded with success!");
            }
            else
            {
                MessageBox.Show("The abstract uploading phase is over!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSpeaker_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void FormSpeaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
            //this.Dispose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idP = _controllerPapers.GetIdPaper();
            string title = tbTitle.Text;
            string keywords = tbKeywords.Text;
            string topics = tbKeywords.Text;
            string authors = tbAbstract.Text;
            string publisher = tbPublisher.Text;
            string date = tbData.Text;
            int idS = _controllerPapers.GetSectionId(ComboBoxSections.SelectedItem.ToString());

            string path = "";
            if(!(tbAbstract.Text.Equals("")))
            {
                path = tbAbstract.Text;
            }
            else if(!(tbPaper.Text.Equals("")))
            {
                path = tbPaper.Text;
            }
            else
            {
                MessageBox.Show("Add path of file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(!(path.Equals("")))
            {
                _controllerPapers.SavePaper(new Paper(idP,title,keywords,topics,authors,publisher,date,path,idS));
                _controllerPapers.UpdatePaperSpeaker(loggedUser.Username,idP);
                MessageBox.Show("Saved to DB!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
