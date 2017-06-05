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
		ControllerListeners ctrll;
        Form prevForm;
        public FormListener(Listener l, Form prev)
        {
            loggedUser = new Listener();
            ctrlp = new ControllerPapers();
			ctrll = new ControllerListeners();
			loggedUser = l;
            InitializeComponent();
            List<Paper> paperList = (List<Paper>)ctrlp.GetAllAcceptedPapers();
            foreach (Paper p in paperList)
            {
                checkedListBox1.Items.Add(p.IdP.ToString() + '.' + p.Title);

            }
            label2.Text = l.Username;
            prevForm = prev;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 5)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("You can't attend more than 5 presentations !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormListener_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				string s = (string)checkedListBox1.Items[i];
				string[] res = s.Split('.');
				int id;
				int.TryParse(res[0], out id);
				if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
				{
					ctrll.addListener(loggedUser.Username, id);
				}
			}
			MessageBox.Show("Submit was succesful!");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void FormListener_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
