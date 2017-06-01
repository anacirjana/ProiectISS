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
        public FormBidProposals(CommitteeMember cm)
        {
            loggedUser = new CommitteeMember();
            ctrlp = new ControllerPapers();
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
    }
}
