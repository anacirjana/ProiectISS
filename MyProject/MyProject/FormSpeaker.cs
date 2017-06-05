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
namespace MyProject
{
    public partial class FormSpeaker : Form
    {
        Speaker loggedUser;
        Form prevForm;
        public FormSpeaker(Speaker s, Form prev)
        {
            loggedUser = s;
            InitializeComponent();
            LabelUsername.Text = s.Username;
            prevForm = prev;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();

            op1.Multiselect = true;

            op1.ShowDialog();

            op1.Filter = "allfiles|*.doc*";

            textBox1.Text = op1.FileName;

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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();

            op1.Multiselect = true;

            op1.ShowDialog();

            op1.Filter = "allfiles|*.docx";

            textBox1.Text = op1.FileName;

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
    }
}
