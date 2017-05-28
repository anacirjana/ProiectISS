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
        ControllerCommitteeMembers controllerCM;
        CommitteeMember loggedUser;
        public FormCommitteeMember(CommitteeMember c)
        {
            loggedUser = new CommitteeMember();
            loggedUser = c;
            
            InitializeComponent();

            LabelUsername.Text = loggedUser.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {

            label6.ForeColor = Color.DeepSkyBlue;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBidProposals formBid = new FormBidProposals(loggedUser);
            formBid.Show();
        }
    }
}
