using MyProject.Controller;
using MyProject.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class FormAssignment : Form
    {
        ControllerPapers ctrp;
        ControllerBiddings ctrb;
        ControllerReviews ctrr;
        CommitteeMember loggedChair;
        Form prevForm;
      

        public FormAssignment(CommitteeMember chair, Form prev)
        {
            loggedChair = chair;
            InitializeComponent();
            ctrp = new ControllerPapers();
            List<Paper> paperList = (List<Paper>)ctrp.GetAllPapers();
            foreach (Paper p in paperList)
            {
                listBox1.Items.Add(p.IdP.ToString() + '.' + p.Title);

            }
            prevForm = prev;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            ctrb = new ControllerBiddings();
            List<Bidding> biddingList = (List<Bidding>)ctrb.getAllBiddings();
            string t = (string)(listBox1.SelectedItem);
            string[] res = t.Split('.');
            int id;
            int.TryParse(res[0], out id);
            foreach(Bidding b in biddingList)
            {
                if (b.IdPaper == id && b.Accepted == true)
                    checkedListBox1.Items.Add(b.UsernameCommitteeMember);


            }
            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //assign
        private void button2_Click(object sender, EventArgs e)
        {
            ctrr = new ControllerReviews();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string username = itemChecked.ToString();
              
                string t = (string)(listBox1.SelectedItem);
                string[] res = t.Split('.');
                int id;
                int.TryParse(res[0], out id);
             
                ctrr.AddReview(new Review(username, id, "", ""));
                
                MessageBox.Show("Assignment made to "+ username);
            }

            

            //clear checked boxes
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void FormAssignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
