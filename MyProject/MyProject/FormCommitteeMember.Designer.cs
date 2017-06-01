namespace MyProject
{
    partial class FormCommitteeMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chgDdlineLab = new System.Windows.Forms.Label();
            this.ddLineCB = new System.Windows.Forms.ComboBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.ddLineBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to CMS,";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelUsername.Location = new System.Drawing.Point(352, 7);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(205, 49);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(29, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bid proposals";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // chgDdlineLab
            // 
            this.chgDdlineLab.AutoSize = true;
            this.chgDdlineLab.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chgDdlineLab.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chgDdlineLab.Location = new System.Drawing.Point(29, 134);
            this.chgDdlineLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgDdlineLab.Name = "chgDdlineLab";
            this.chgDdlineLab.Size = new System.Drawing.Size(171, 26);
            this.chgDdlineLab.TabIndex = 10;
            this.chgDdlineLab.Text = "Change Deadline";
            this.chgDdlineLab.Click += new System.EventHandler(this.chgDdlineLab_Click);
            this.chgDdlineLab.MouseLeave += new System.EventHandler(this.chgDdlineLab_MouseLeave);
            this.chgDdlineLab.MouseHover += new System.EventHandler(this.chgDdlineLab_MouseHover);
            // 
            // ddLineCB
            // 
            this.ddLineCB.FormattingEnabled = true;
            this.ddLineCB.Location = new System.Drawing.Point(206, 138);
            this.ddLineCB.Name = "ddLineCB";
            this.ddLineCB.Size = new System.Drawing.Size(121, 21);
            this.ddLineCB.TabIndex = 11;
            this.ddLineCB.Visible = false;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(334, 138);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(100, 20);
            this.dateTB.TabIndex = 12;
            this.dateTB.Visible = false;
            // 
            // ddLineBtn
            // 
            this.ddLineBtn.Location = new System.Drawing.Point(441, 135);
            this.ddLineBtn.Name = "ddLineBtn";
            this.ddLineBtn.Size = new System.Drawing.Size(75, 23);
            this.ddLineBtn.TabIndex = 13;
            this.ddLineBtn.Text = "Change";
            this.ddLineBtn.UseVisualStyleBackColor = true;
            this.ddLineBtn.Visible = false;
            this.ddLineBtn.Click += new System.EventHandler(this.ddLineBtn_Click);
            // 
            // FormCommitteeMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.ddLineBtn);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.ddLineCB);
            this.Controls.Add(this.chgDdlineLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCommitteeMember";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label chgDdlineLab;
        private System.Windows.Forms.ComboBox ddLineCB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Button ddLineBtn;
    }
}

