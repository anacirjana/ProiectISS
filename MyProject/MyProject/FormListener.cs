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
    public partial class FormListener : Form
    {
        Listener loggedUser;
        ControllerPapers ctrlp;
        public FormListener(Listener l)
        {
            loggedUser = new Listener();
            ctrlp = new ControllerPapers();
            loggedUser = l;
            InitializeComponent();
            List<Paper> paperList = (List<Paper>)ctrlp.GetAllAcceptedPapers();
            foreach (Paper p in paperList)
            {
                checkedListBox1.Items.Add(p.IdP.ToString() + '.' + p.Title);

            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 5)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Va rugam selectati doar 5 lucrari !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
