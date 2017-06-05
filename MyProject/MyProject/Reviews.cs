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
    public partial class Reviews : Form
    {
        private string _username;
        private ControllerReviews _controllerReview;
        private ControllerPapers _controllerPaper;
        Form prevForm;

        public Reviews(string username, Form prev)
        {
            InitializeComponent();
            
            _username = username;
            _controllerReview = new ControllerReviews();
            _controllerPaper = new ControllerPapers();

            AddQualifiers();
            GetPapers();
            prevForm = prev;
        }

        private void AddQualifiers()
        {
            comboBox1.Items.Add("strong	accept");
            comboBox1.Items.Add("accept");
            comboBox1.Items.Add("weak accept");
            comboBox1.Items.Add("borderline paper");
            comboBox1.Items.Add("weak reject");
            comboBox1.Items.Add("reject");
            comboBox1.Items.Add("strong reject");
        }

        private void GetPapers()
        {
            List<int> reviews = _controllerReview.GetPapersforUser(_username);
            IEnumerable<Paper> papers = _controllerPaper.GetAllPapers();
            List<Paper> finalPapers = new List<Paper>();

            foreach(int i in reviews)
            {
                foreach(Paper p in papers)
                {
                    if(p.IdP == i)
                    {
                        finalPapers.Add(p);
                    }
                }
            }

            listBox1.DataSource = finalPapers;
            listBox1.DisplayMember = "Title";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object paperObj = listBox1.SelectedItem;
            Paper paper = (Paper)paperObj;
            string comment = richTextBox1.Text;
            string qualifier = comboBox1.GetItemText(comboBox1.SelectedItem);
            Review review = new Review(_username, paper.IdP, (string)qualifier, (string)comment);
            int idR = _controllerReview.GetReviewId(_username, paper.IdP);
            Review reviewOld = _controllerReview.GetOne(idR);
            _controllerReview.UpdateReview(reviewOld, review);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void Reviews_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }
    }
}
