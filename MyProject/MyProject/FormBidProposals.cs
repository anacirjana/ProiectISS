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
        public FormBidProposals(CommitteeMember cm)
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
			object path = Path.Combine(ExecutableLocation,"PaperContents/Bayes.docx");
			object readOnly = true;
			Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
			string totaltext = docs.Content.Text;
			docs.Close();
			word.Quit();
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
    }
}
