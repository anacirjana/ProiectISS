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
    public partial class FormCommitteeMember : Form
    {
        RepositoryCommitteeMembers repositoryCM;
        ControllerCommitteeMembers controllerCM;
        User loggedUser;
        public FormCommitteeMember(User u)
        {
            loggedUser = new User();
            loggedUser = u;
            
            InitializeComponent();

            LabelUsername.Text = loggedUser.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
