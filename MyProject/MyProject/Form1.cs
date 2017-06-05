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
    public partial class Form1 : Form
    {
        ControllerCommitteeMembers controllerCM;
        ControllerListeners controllerL;
        ControllerSpeakers controllerS;

        public Form1()
        {
            controllerCM = new ControllerCommitteeMembers();
            controllerL = new ControllerListeners();
            controllerS = new ControllerSpeakers();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            var item = ComboBoxParticipants.SelectedItem;
            if (item == "Committee Member")
            {
                CommitteeMember cm = controllerCM.Login(username, password);
                if (cm.Username == username) //login successful
                {
                    this.Hide();
                    FormCommitteeMember secondform = new FormCommitteeMember(cm,this);
                    secondform.Show();
                }
            }
            else
                 if (item == "Listener")
            {
                
                Listener l = controllerL.Login(username, password); 
                if (l.Username == username) //login successful
                {
                    this.Hide();
                    FormListener secondform = new FormListener(l,this);
                    secondform.Show();
                }
                
            }
            else
                 if (item == "Speaker")
            {
                
                Speaker s = controllerS.Login(username, password);
                if (s.Username == username) //login successful
                {
                    this.Hide();
                    FormSpeaker secondform = new FormSpeaker(s,this);
                    secondform.Show();
                }
                
            }

        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister secondform = new FormRegister();
            secondform.Show();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DeepSkyBlue;
        }
    }
}
