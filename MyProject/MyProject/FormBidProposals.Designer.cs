namespace MyProject
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
			this.PaperContent = new System.Windows.Forms.TextBox();
			this.CheckedListBoxProposals = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MintCream;
			this.panel1.Controls.Add(this.PaperContent);
			this.panel1.Controls.Add(this.CheckedListBoxProposals);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(930, 503);
			this.panel1.TabIndex = 2;
			// 
			// PaperContent
			// 
			this.PaperContent.BackColor = System.Drawing.Color.Bisque;
			this.PaperContent.Location = new System.Drawing.Point(413, 89);
			this.PaperContent.MaxLength = 100000;
			this.PaperContent.Multiline = true;
			this.PaperContent.Name = "PaperContent";
			this.PaperContent.ReadOnly = true;
			this.PaperContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.PaperContent.Size = new System.Drawing.Size(491, 395);
			this.PaperContent.TabIndex = 3;
			// 
			// CheckedListBoxProposals
			// 
			this.CheckedListBoxProposals.FormattingEnabled = true;
			this.CheckedListBoxProposals.Location = new System.Drawing.Point(23, 89);
			this.CheckedListBoxProposals.Name = "CheckedListBoxProposals";
			this.CheckedListBoxProposals.Size = new System.Drawing.Size(351, 395);
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
			// FormBidProposals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 503);
			this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox PaperContent;
    }
}