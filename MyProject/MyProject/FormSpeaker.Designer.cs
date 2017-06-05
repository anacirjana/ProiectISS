namespace MyProject
{
    partial class FormSpeaker
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.tbTopics = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthors = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxSections = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 27F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to CMS,";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Trebuchet MS", 27F, System.Drawing.FontStyle.Bold);
            this.LabelUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelUsername.Location = new System.Drawing.Point(435, 22);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(232, 57);
            this.LabelUsername.TabIndex = 3;
            this.LabelUsername.Text = "username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(579, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "(Re)Upload Paper";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(579, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "(Re)Upload Abstract";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MyProject.Properties.Resources.inapoi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 498);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(221, 116);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(213, 22);
            this.tbTitle.TabIndex = 26;
            this.tbTitle.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(76, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(17, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Keywords:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(59, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Topics:";
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(220, 174);
            this.tbKeywords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(213, 22);
            this.tbKeywords.TabIndex = 30;
            // 
            // tbTopics
            // 
            this.tbTopics.Location = new System.Drawing.Point(219, 234);
            this.tbTopics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTopics.Name = "tbTopics";
            this.tbTopics.Size = new System.Drawing.Size(213, 22);
            this.tbTopics.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(43, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Authors:";
            // 
            // tbAuthors
            // 
            this.tbAuthors.Location = new System.Drawing.Point(219, 295);
            this.tbAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthors.Name = "tbAuthors";
            this.tbAuthors.Size = new System.Drawing.Size(213, 22);
            this.tbAuthors.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(27, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Publisher:";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(216, 354);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(213, 22);
            this.tbPublisher.TabIndex = 35;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(216, 411);
            this.tbData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(213, 22);
            this.tbData.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(81, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 37;
            this.label7.Text = "Date:";
            // 
            // ComboBoxSections
            // 
            this.ComboBoxSections.BackColor = System.Drawing.Color.AliceBlue;
            this.ComboBoxSections.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxSections.DropDownHeight = 130;
            this.ComboBoxSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSections.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSections.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ComboBoxSections.FormattingEnabled = true;
            this.ComboBoxSections.IntegralHeight = false;
            this.ComboBoxSections.Items.AddRange(new object[] {
            "Medicine",
            "Math&CS",
            "Environment"});
            this.ComboBoxSections.Location = new System.Drawing.Point(219, 457);
            this.ComboBoxSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSections.Name = "ComboBoxSections";
            this.ComboBoxSections.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSections.Size = new System.Drawing.Size(212, 31);
            this.ComboBoxSections.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(-5, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 32);
            this.label8.TabIndex = 39;
            this.label8.Text = "Choose section:";
            // 
            // FormSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::MyProject.Properties.Resources.cm;
            this.ClientSize = new System.Drawing.Size(961, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBoxSections);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAuthors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTopics);
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSpeaker";
            this.Text = "Speaker Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSpeaker_FormClosing);
            this.Load += new System.EventHandler(this.FormSpeaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.TextBox tbTopics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAuthors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxSections;
        private System.Windows.Forms.Label label8;
    }
}
