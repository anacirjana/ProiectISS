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
        Form prevForm;
        public FormCommitteeMember(CommitteeMember c, Form prev)
        {
            controllerCM = new ControllerCommitteeMembers();
            loggedUser = new CommitteeMember();
            loggedUser = c;
            
            InitializeComponent();

            LabelUsername.Text = loggedUser.Username;
            if(c.Role == "chair")
            {
                label4.Visible = true;
            }
            prevForm = prev;
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
            if(DateTime.Today < controllerCM.GetTime())
            {
                this.Hide();
                FormBidProposals formBid = new FormBidProposals(loggedUser, this);
                formBid.Show();
            }
            else if(DateTime.Today < controllerCM.GetAbstractDeadline())
            {
                MessageBox.Show("The abstract uploading phase is not over yet!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The bidding phase is over!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chgDdlineLab_Click(object sender, EventArgs e)
        {
            ddLineCB.Visible = true;
            dateTB.Visible = true;
            ddLineBtn.Visible = true;

            List<string> list = controllerCM.GetNames();
            foreach(string s in list)
            {
                ddLineCB.Items.Add(s);
            }
        }

        private void ddLineBtn_Click(object sender, EventArgs e)
        {
            string name = ddLineCB.SelectedItem.ToString();
            DateTime date = Convert.ToDateTime(dateTB.Text);
            controllerCM.ChangeDeadline(name, date);

            ddLineCB.Visible = false;
            dateTB.Visible = false;
            ddLineBtn.Visible = false;
        }

        private void chgDdlineLab_Enter(object sender, EventArgs e)
        {
        }

        private void chgDdlineLab_MouseHover(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(DateTime.Today > controllerCM.GetTime())
            {
                this.Hide();
                string username = loggedUser.Username;
                Reviews formReview = new Reviews(username,this);
                formReview.Show();
            }
            else
            {
                MessageBox.Show("The bidding phase is not over yet!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAssignment formAsg = new FormAssignment(loggedUser,this);

            formAsg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        

        private void chgDdlineLab_Leave(object sender, EventArgs e)
        {
            //chgDdlineLab.ForeColor = Color.SkyBlue;
        }

        private void chgDdlineLab_MouseEnter(object sender, EventArgs e)
        {
            chgDdlineLab.ForeColor = Color.Red;
        }
        private void chgDdlineLab_MouseLeave(object sender, EventArgs e)
        {
            chgDdlineLab.ForeColor = Color.DeepSkyBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DeepSkyBlue;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DeepSkyBlue;
        }

        private void ddLineBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void FormCommitteeMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
