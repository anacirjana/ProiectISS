using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.Domain;
using Microsoft.Office;
using MyProject.Controller;
using System.Reflection;

namespace MyProject
{
    public partial class FormBidProposals : Form
    {
        CommitteeMember loggedUser;
        ControllerPapers ctrlp;
        ControllerBiddings ctrlb;
        Form prevForm;
        public FormBidProposals(CommitteeMember cm, Form prev)
        {
            loggedUser = new CommitteeMember();
            ctrlp = new ControllerPapers();
            ctrlb = new ControllerBiddings();
            loggedUser = cm;
            InitializeComponent();
            List<Paper> paperList = (List<Paper>)ctrlp.GetAllPapers();
            foreach (Paper p in paperList)
            {
                CheckedListBoxProposals.Items.Add(p.IdP.ToString()+'.'+p.Title);
               
            }
            prevForm = prev;
        }

        private void FormBidProposals_Load(object sender, EventArgs e)
        {           
            
        }

        private void CheckedListBoxProposals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = (string)(CheckedListBoxProposals.SelectedItem);
            string[] res = t.Split('.');
            int id;
            int.TryParse(res[0], out id);
			Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
			object miss = System.Reflection.Missing.Value;
            string ExecutableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pathh = ctrlp.GetPathPaper(id);
            string[] dirfile = pathh.Split('/');
            string fin = dirfile[0] + "\\" + dirfile[1];
            object path = Path.Combine(ExecutableLocation,fin);
			object readOnly = true;
			Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
			string totaltext = docs.Content.Text;
           
           // PaperContent
            //docs.Content.
			docs.Close();
			word.Quit();
            // PaperContent.Rtf = totaltext;
            PaperContent.Font = new Font("Trebuchet MS",13);
           PaperContent.Text = totaltext;

		}

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0;i< CheckedListBoxProposals.Items.Count;i++)
            {
                string s = (string)CheckedListBoxProposals.Items[i];
                string[] res = s.Split('.');
                int id;
                int.TryParse(res[0], out id);
                if (CheckedListBoxProposals.GetItemCheckState(i) == CheckState.Checked)
                {
                    Bidding b = new Bidding(loggedUser.Username, id, true);
                    ctrlb.addBidding(b);
                }else
                {
                    Bidding b = new Bidding(loggedUser.Username, id, false);
                    ctrlb.addBidding(b);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void FormBidProposals_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }
    }
}
