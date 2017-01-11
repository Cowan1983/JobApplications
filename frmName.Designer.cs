namespace JobApplication
{
    partial class frmName
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
            this.btnCancelCloseName = new System.Windows.Forms.Button();
            this.btnUpdateCloseName = new System.Windows.Forms.Button();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblNameFirstName = new System.Windows.Forms.Label();
            this.lblNameMiddleName = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtBoxNameFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxNameMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxNameSurname = new System.Windows.Forms.TextBox();
            this.cboBoxNameTitles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelCloseName
            // 
            this.btnCancelCloseName.Location = new System.Drawing.Point(163, 134);
            this.btnCancelCloseName.Name = "btnCancelCloseName";
            this.btnCancelCloseName.Size = new System.Drawing.Size(103, 23);
            this.btnCancelCloseName.TabIndex = 5;
            this.btnCancelCloseName.Text = "Cancel and Close";
            this.btnCancelCloseName.UseVisualStyleBackColor = true;
            this.btnCancelCloseName.Click += new System.EventHandler(this.btnCancelCloseName_Click);
            // 
            // btnUpdateCloseName
            // 
            this.btnUpdateCloseName.Location = new System.Drawing.Point(12, 134);
            this.btnUpdateCloseName.Name = "btnUpdateCloseName";
            this.btnUpdateCloseName.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateCloseName.TabIndex = 4;
            this.btnUpdateCloseName.Text = "Update and Close";
            this.btnUpdateCloseName.UseVisualStyleBackColor = true;
            this.btnUpdateCloseName.Click += new System.EventHandler(this.btnUpdateCloseName_Click);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(9, 82);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(52, 13);
            this.lblNameSurname.TabIndex = 6;
            this.lblNameSurname.Text = "Surname:";
            // 
            // lblNameFirstName
            // 
            this.lblNameFirstName.AutoSize = true;
            this.lblNameFirstName.Location = new System.Drawing.Point(9, 34);
            this.lblNameFirstName.Name = "lblNameFirstName";
            this.lblNameFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblNameFirstName.TabIndex = 7;
            this.lblNameFirstName.Text = "First Name:";
            // 
            // lblNameMiddleName
            // 
            this.lblNameMiddleName.AutoSize = true;
            this.lblNameMiddleName.Location = new System.Drawing.Point(9, 57);
            this.lblNameMiddleName.Name = "lblNameMiddleName";
            this.lblNameMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblNameMiddleName.TabIndex = 8;
            this.lblNameMiddleName.Text = "Middle Name:";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(12, 9);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(30, 13);
            this.lblNameTitle.TabIndex = 9;
            this.lblNameTitle.Text = "Title:";
            // 
            // txtBoxNameFirstName
            // 
            this.txtBoxNameFirstName.Location = new System.Drawing.Point(82, 31);
            this.txtBoxNameFirstName.Name = "txtBoxNameFirstName";
            this.txtBoxNameFirstName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNameFirstName.TabIndex = 10;
            // 
            // txtBoxNameMiddleName
            // 
            this.txtBoxNameMiddleName.Location = new System.Drawing.Point(82, 54);
            this.txtBoxNameMiddleName.Name = "txtBoxNameMiddleName";
            this.txtBoxNameMiddleName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNameMiddleName.TabIndex = 11;
            // 
            // txtBoxNameSurname
            // 
            this.txtBoxNameSurname.Location = new System.Drawing.Point(82, 79);
            this.txtBoxNameSurname.Name = "txtBoxNameSurname";
            this.txtBoxNameSurname.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNameSurname.TabIndex = 12;
            // 
            // cboBoxNameTitles
            // 
            this.cboBoxNameTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxNameTitles.FormattingEnabled = true;
            this.cboBoxNameTitles.Items.AddRange(new object[] {
            "Mr",
            "Miss",
            "Mrs",
            "Dr",
            "Professor"});
            this.cboBoxNameTitles.Location = new System.Drawing.Point(82, 6);
            this.cboBoxNameTitles.Name = "cboBoxNameTitles";
            this.cboBoxNameTitles.Size = new System.Drawing.Size(184, 21);
            this.cboBoxNameTitles.TabIndex = 13;
            // 
            // frmName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 164);
            this.Controls.Add(this.cboBoxNameTitles);
            this.Controls.Add(this.txtBoxNameSurname);
            this.Controls.Add(this.txtBoxNameMiddleName);
            this.Controls.Add(this.txtBoxNameFirstName);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblNameMiddleName);
            this.Controls.Add(this.lblNameFirstName);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.btnCancelCloseName);
            this.Controls.Add(this.btnUpdateCloseName);
            this.Name = "frmName";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCloseName;
        private System.Windows.Forms.Button btnUpdateCloseName;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblNameFirstName;
        private System.Windows.Forms.Label lblNameMiddleName;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox txtBoxNameFirstName;
        private System.Windows.Forms.TextBox txtBoxNameMiddleName;
        private System.Windows.Forms.TextBox txtBoxNameSurname;
        private System.Windows.Forms.ComboBox cboBoxNameTitles;
    }
}