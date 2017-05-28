using MyProject.Controller;
using MyProject.Domain;
using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboSel = ComboBoxParticipants.SelectedItem.ToString();
            string iban = textBox5.Text;

            if(iban.Length != 24)
            {
                MessageBox.Show("IBAN length is wrong!", "IBAN check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Regex.IsMatch(iban.Substring(0,2), @"^[A-Z]+$")))
            {
                MessageBox.Show("First 2 letters of IBAN must be uppercase letters!", "IBAN check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Regex.IsMatch(iban.Substring(2,2), @"^[0-9]+$")))
            {
                MessageBox.Show("Letters 3 and 4 of IBAN must be numbers!", "IBAN check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Regex.IsMatch(iban.Substring(4, 4), @"^[A-Z]+$")))
            {
                MessageBox.Show("Letters 5 to 8 of IBAN must be uppercase letters!", "IBAN check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Regex.IsMatch(iban.Substring(8,16), @"^[A-Z0-9]+$")))
            {
                MessageBox.Show("Letters 9 to 24 of IBAN must be uppercase letters or numbers!", "IBAN check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSel == "Listener")
            {
                ControllerListeners ctrListners = new ControllerListeners(new RepositoryListeners());
                ctrListners.Register(new Listener(textBox3.Text,TextBoxPassword.Text,textBox1.Text,
                                                        textBox2.Text,textBox4.Text));
            }
            else if(comboSel == "Speaker")
            {
                ControllerSpeakers ctrSpeakers = new ControllerSpeakers(new RepositorySpeakers());
				ctrSpeakers.Register(new Speaker(textBox3.Text, TextBoxPassword.Text, textBox1.Text,
                                                        textBox2.Text, textBox4.Text));
            }
        }
    }
}
