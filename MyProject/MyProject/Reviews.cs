﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.Domain;

namespace MyProject
{
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object paperObj = listBox1.SelectedItem;
            Paper paper = (Paper)paperObj;
            string comment = richTextBox1.Text;
            string qualifier = comboBox1.GetItemText(comboBox1.SelectedItem);
            Review review = new Review(username, paper.IdP, (string)qualifier, (string)comment);
        }
    }
}
