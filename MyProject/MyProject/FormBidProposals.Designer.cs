﻿namespace MyProject
{
    partial class FormBidProposals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckedListBoxProposals = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaperContent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.PaperContent);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CheckedListBoxProposals);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 503);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(23, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckedListBoxProposals
            // 
            this.CheckedListBoxProposals.FormattingEnabled = true;
            this.CheckedListBoxProposals.Location = new System.Drawing.Point(23, 89);
            this.CheckedListBoxProposals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckedListBoxProposals.Name = "CheckedListBoxProposals";
            this.CheckedListBoxProposals.Size = new System.Drawing.Size(351, 327);
            this.CheckedListBoxProposals.TabIndex = 1;
            this.CheckedListBoxProposals.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxProposals_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bid proposals";
            // 
            // PaperContent
            // 
            this.PaperContent.AcceptsTab = true;
            this.PaperContent.BackColor = System.Drawing.Color.Linen;
            this.PaperContent.Location = new System.Drawing.Point(399, 12);
            this.PaperContent.Name = "PaperContent";
            this.PaperContent.ReadOnly = true;
            this.PaperContent.Size = new System.Drawing.Size(520, 479);
            this.PaperContent.TabIndex = 5;
            this.PaperContent.Text = "";
            this.PaperContent.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormBidProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBidProposals";
            this.Text = "FormBidProposals";
            this.Load += new System.EventHandler(this.FormBidProposals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CheckedListBoxProposals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox PaperContent;
    }
}