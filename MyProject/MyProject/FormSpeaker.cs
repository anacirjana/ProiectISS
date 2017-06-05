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
        public void saveToDB(string path)
        {
            int idP = _controllerPapers.GetIdPaper();
            string title = tbTitle.Text;
            string keywords = tbKeywords.Text;
            string topics = tbKeywords.Text;
            string authors = tbAuthors.Text;
            string publisher = tbPublisher.Text;
            string date = tbData.Text;
            int idS=1;
            if (title == "" || keywords == "" || authors == "" || topics == "" || publisher == "" || date == "" || ComboBoxSections.SelectedItem == null)
                MessageBox.Show("Please complete all fields!");
            //string path = "";
            else
            {
                idS = _controllerPapers.GetSectionId(ComboBoxSections.SelectedItem.ToString());



                if (!(path.Equals("")))
                {
                    _controllerPapers.SavePaper(new Paper(idP, title, keywords, topics, authors, publisher, date, path, idS));
                    _controllerPapers.UpdatePaperSpeaker(loggedUser.Username, idP);
                   // MessageBox.Show("Saved to DB!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Today < _controllerPapers.GetPaperDeadline())
            {

                OpenFileDialog op1 = new OpenFileDialog();

                op1.Multiselect = true;

                op1.ShowDialog();

                op1.Filter = "allfiles|*.doc*";

               // tbPaper.Text = op1.FileName;

                int count = 0;

                string[] FName;

                foreach (string s in op1.FileNames)

                {

                    FName = s.Split('\\');
                    string ExecutableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string path = Path.Combine(ExecutableLocation, "PaperContents\\");
                    path = path + FName[FName.Length - 1];
                   // File.
                    File.Copy(s, path);
                    saveToDB("PaperContents/"+ FName[FName.Length - 1]);
                    count++;

                }
                if (count != 0)
                    MessageBox.Show("Uploaded with success!");
                else
                    MessageBox.Show("Could not upload");
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

               // tbPaper.Text = op1.FileName;

                int count = 0;

                string[] FName;

                foreach (string s in op1.FileNames)

                {

                    FName = s.Split('\\');
                    string ExecutableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string path = Path.Combine(ExecutableLocation, "PaperContents\\");
                    path = path + FName[FName.Length - 1];
                    File.Copy(s, "PaperContents/" + FName[FName.Length - 1]);

                    saveToDB(path);
                    count++;

                }
                if (count != 0)
                    MessageBox.Show("Uploaded with success!");
                else
                    MessageBox.Show("Could not upload");
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
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
