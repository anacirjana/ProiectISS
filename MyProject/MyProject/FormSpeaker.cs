using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.IO;
using System.Reflection;
using MyProject.Domain;
namespace MyProject
{
    public partial class FormSpeaker : Form
    {
        Speaker loggedUser;
        public FormSpeaker(Speaker s)
        {
            loggedUser = s;
            InitializeComponent();
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
    }
}
