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
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chgDdlineLab = new System.Windows.Forms.Label();
            this.ddLineCB = new System.Windows.Forms.ComboBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddLineBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(35, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to CMS,";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelUsername.Location = new System.Drawing.Point(469, 9);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(258, 63);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(39, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
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
            this.chgDdlineLab.Location = new System.Drawing.Point(39, 165);
            this.chgDdlineLab.Name = "chgDdlineLab";
            this.chgDdlineLab.Size = new System.Drawing.Size(209, 32);
            this.chgDdlineLab.TabIndex = 10;
            this.chgDdlineLab.Text = "Change Deadline";
            this.chgDdlineLab.Click += new System.EventHandler(this.chgDdlineLab_Click);
            this.chgDdlineLab.Enter += new System.EventHandler(this.chgDdlineLab_Enter);
            this.chgDdlineLab.Leave += new System.EventHandler(this.chgDdlineLab_Leave);
            this.chgDdlineLab.MouseEnter += new System.EventHandler(this.chgDdlineLab_MouseEnter);
            this.chgDdlineLab.MouseLeave += new System.EventHandler(this.chgDdlineLab_MouseLeave);
            // 
            // ddLineCB
            // 
            this.ddLineCB.FormattingEnabled = true;
            this.ddLineCB.Location = new System.Drawing.Point(275, 170);
            this.ddLineCB.Margin = new System.Windows.Forms.Padding(4);
            this.ddLineCB.Name = "ddLineCB";
            this.ddLineCB.Size = new System.Drawing.Size(160, 24);
            this.ddLineCB.TabIndex = 11;
            this.ddLineCB.Visible = false;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(445, 170);
            this.dateTB.Margin = new System.Windows.Forms.Padding(4);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(132, 22);
            this.dateTB.TabIndex = 12;
            this.dateTB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(40, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Add reviews";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(40, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Assign papers for review";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MyProject.Properties.Resources.inapoi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ddLineBtn
            // 
            this.ddLineBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ddLineBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ddLineBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ddLineBtn.Location = new System.Drawing.Point(584, 165);
            this.ddLineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddLineBtn.Name = "ddLineBtn";
            this.ddLineBtn.Size = new System.Drawing.Size(122, 36);
            this.ddLineBtn.TabIndex = 21;
            this.ddLineBtn.Text = "Change";
            this.ddLineBtn.UseVisualStyleBackColor = false;
            this.ddLineBtn.Visible = false;
            this.ddLineBtn.Click += new System.EventHandler(this.ddLineBtn_Click_1);
            // 
            // FormCommitteeMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::MyProject.Properties.Resources.cm;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.ddLineBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.ddLineCB);
            this.Controls.Add(this.chgDdlineLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCommitteeMember";
            this.Text = "Committee Member Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCommitteeMember_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label chgDdlineLab;
        private System.Windows.Forms.ComboBox ddLineCB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ddLineBtn;
    }
}

