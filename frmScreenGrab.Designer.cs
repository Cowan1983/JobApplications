namespace JobApplication
{
    partial class frmScreenGrab
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPicBoxPanel = new System.Windows.Forms.Panel();
            this.picBoxJobLead = new System.Windows.Forms.PictureBox();
            this.btnPasteFrmClipboard = new System.Windows.Forms.Button();
            this.pnlPicBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJobLead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlPicBoxPanel
            // 
            this.pnlPicBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPicBoxPanel.AutoScroll = true;
            this.pnlPicBoxPanel.Controls.Add(this.picBoxJobLead);
            this.pnlPicBoxPanel.Location = new System.Drawing.Point(2, 3);
            this.pnlPicBoxPanel.Name = "pnlPicBoxPanel";
            this.pnlPicBoxPanel.Size = new System.Drawing.Size(1089, 556);
            this.pnlPicBoxPanel.TabIndex = 51;
            // 
            // picBoxJobLead
            // 
            this.picBoxJobLead.Location = new System.Drawing.Point(3, 3);
            this.picBoxJobLead.Name = "picBoxJobLead";
            this.picBoxJobLead.Size = new System.Drawing.Size(240, 173);
            this.picBoxJobLead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxJobLead.TabIndex = 47;
            this.picBoxJobLead.TabStop = false;
            // 
            // btnPasteFrmClipboard
            // 
            this.btnPasteFrmClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteFrmClipboard.Location = new System.Drawing.Point(1007, 565);
            this.btnPasteFrmClipboard.Name = "btnPasteFrmClipboard";
            this.btnPasteFrmClipboard.Size = new System.Drawing.Size(75, 23);
            this.btnPasteFrmClipboard.TabIndex = 50;
            this.btnPasteFrmClipboard.Text = "Paste";
            this.btnPasteFrmClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFrmClipboard.Click += new System.EventHandler(this.btnPasteFrmClipboard_Click);
            // 
            // frmScreenGrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 600);
            this.Controls.Add(this.pnlPicBoxPanel);
            this.Controls.Add(this.btnPasteFrmClipboard);
            this.Controls.Add(this.btnClose);
            this.Name = "frmScreenGrab";
            this.Text = "Screen Grab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPicBoxPanel.ResumeLayout(false);
            this.pnlPicBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxJobLead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlPicBoxPanel;
        private System.Windows.Forms.PictureBox picBoxJobLead;
        private System.Windows.Forms.Button btnPasteFrmClipboard;
    }
}