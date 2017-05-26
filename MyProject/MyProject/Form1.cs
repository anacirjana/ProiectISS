using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.Domain;
using MyProject.Repository;
using MyProject.Controller;
namespace MyProject
{
    public partial class Form1 : Form
    {
        RepositoryCommitteeMembers repositoryCM;
        ControllerCommitteeMembers controllerCM;
        public Form1()
        {
            repositoryCM = new RepositoryCommitteeMembers();
            controllerCM = new ControllerCommitteeMembers(repositoryCM);
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            CommitteeMember cm = controllerCM.Login(username, password);
            if (cm.Username == username) //login successful
            {
                this.Hide();
                Form2 secondform = new Form2(cm);  
                secondform.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DeepSkyBlue;
        }
    }
}
