namespace JobApplication
{
    partial class frmNote
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
            this.btnCancelCloseNote = new System.Windows.Forms.Button();
            this.btnUpdateCloseNote = new System.Windows.Forms.Button();
            this.rTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.txtBoxNoteDate = new System.Windows.Forms.TextBox();
            this.rTxtBoxAllNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCancelCloseNote
            // 
            this.btnCancelCloseNote.Location = new System.Drawing.Point(743, 421);
            this.btnCancelCloseNote.Name = "btnCancelCloseNote";
            this.btnCancelCloseNote.Size = new System.Drawing.Size(103, 23);
            this.btnCancelCloseNote.TabIndex = 5;
            this.btnCancelCloseNote.Text = "Cancel and Close";
            this.btnCancelCloseNote.UseVisualStyleBackColor = true;
            this.btnCancelCloseNote.Click += new System.EventHandler(this.btnCancelCloseNote_Click);
            // 
            // btnUpdateCloseNote
            // 
            this.btnUpdateCloseNote.Location = new System.Drawing.Point(12, 421);
            this.btnUpdateCloseNote.Name = "btnUpdateCloseNote";
            this.btnUpdateCloseNote.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateCloseNote.TabIndex = 4;
            this.btnUpdateCloseNote.Text = "Update and Close";
            this.btnUpdateCloseNote.UseVisualStyleBackColor = true;
            this.btnUpdateCloseNote.Click += new System.EventHandler(this.btnUpdateCloseNote_Click);
            // 
            // rTextBoxNote
            // 
            this.rTextBoxNote.Location = new System.Drawing.Point(12, 298);
            this.rTextBoxNote.Name = "rTextBoxNote";
            this.rTextBoxNote.Size = new System.Drawing.Size(834, 117);
            this.rTextBoxNote.TabIndex = 6;
            this.rTextBoxNote.Text = "";
            // 
            // txtBoxNoteDate
            // 
            this.txtBoxNoteDate.Location = new System.Drawing.Point(12, 6);
            this.txtBoxNoteDate.Name = "txtBoxNoteDate";
            this.txtBoxNoteDate.Size = new System.Drawing.Size(254, 20);
            this.txtBoxNoteDate.TabIndex = 7;
            // 
            // rTxtBoxAllNotes
            // 
            this.rTxtBoxAllNotes.Location = new System.Drawing.Point(12, 32);
            this.rTxtBoxAllNotes.Name = "rTxtBoxAllNotes";
            this.rTxtBoxAllNotes.Size = new System.Drawing.Size(834, 260);
            this.rTxtBoxAllNotes.TabIndex = 8;
            this.rTxtBoxAllNotes.Text = "";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 456);
            this.Controls.Add(this.rTxtBoxAllNotes);
            this.Controls.Add(this.txtBoxNoteDate);
            this.Controls.Add(this.rTextBoxNote);
            this.Controls.Add(this.btnCancelCloseNote);
            this.Controls.Add(this.btnUpdateCloseNote);
            this.Name = "frmNote";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCloseNote;
        private System.Windows.Forms.Button btnUpdateCloseNote;
        private System.Windows.Forms.RichTextBox rTextBoxNote;
        private System.Windows.Forms.TextBox txtBoxNoteDate;
        private System.Windows.Forms.RichTextBox rTxtBoxAllNotes;
    }
}