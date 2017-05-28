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
using MyProject.Controller;
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
            List<Paper> paperList = (List<Paper>)ctrlp.getAllPapers();
            foreach (Paper p in paperList)
            {
                CheckedListBoxProposals.Items.Add(p.Title);
            }
        }

        private void FormBidProposals_Load(object sender, EventArgs e)
        {           
            
        }
    }
}
