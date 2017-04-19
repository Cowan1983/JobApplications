namespace JobApplication
{
    partial class frmJobLead
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
            this.lblCurrentJobStatus = new System.Windows.Forms.Label();
            this.lblJobCreationDateTime = new System.Windows.Forms.Label();
            this.cboJobStatusList = new System.Windows.Forms.ComboBox();
            this.dateTimeCreationDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnCloseJobLead = new System.Windows.Forms.Button();
            this.btnShowAgency = new System.Windows.Forms.Button();
            this.lblAgencyList = new System.Windows.Forms.Label();
            this.cboAgencyNames = new System.Windows.Forms.ComboBox();
            this.btnShowEmployer = new System.Windows.Forms.Button();
            this.lblEmployersList = new System.Windows.Forms.Label();
            this.cboEmployerNames = new System.Windows.Forms.ComboBox();
            this.btnShowEmployerContact = new System.Windows.Forms.Button();
            this.btnShowAgencyContact = new System.Windows.Forms.Button();
            this.lblEmployerContactName = new System.Windows.Forms.Label();
            this.cboEmployerContactNames = new System.Windows.Forms.ComboBox();
            this.lblAgencyContactName = new System.Windows.Forms.Label();
            this.cboAgencyContactNames = new System.Windows.Forms.ComboBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtBoxJobTitle = new System.Windows.Forms.TextBox();
            this.txtBoxLeadSource = new System.Windows.Forms.TextBox();
            this.lblLeadSource = new System.Windows.Forms.Label();
            this.txtBoxApplicationDocLocation = new System.Windows.Forms.TextBox();
            this.lblCVorApplicationLocation = new System.Windows.Forms.Label();
            this.txtBoxCoverLetterLocation = new System.Windows.Forms.TextBox();
            this.lblCoverLetterDocLocation = new System.Windows.Forms.Label();
            this.txtBoxRefOne = new System.Windows.Forms.TextBox();
            this.lblRef1 = new System.Windows.Forms.Label();
            this.txtBoxRefTwo = new System.Windows.Forms.TextBox();
            this.lblRefTwo = new System.Windows.Forms.Label();
            this.txtBoxRefThree = new System.Windows.Forms.TextBox();
            this.lblRefThree = new System.Windows.Forms.Label();
            this.btnNewAgencyBroker = new System.Windows.Forms.Button();
            this.btnNewEmployerBroker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.lblNotesCount = new System.Windows.Forms.Label();
            this.btnPasteFrmClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentJobStatus
            // 
            this.lblCurrentJobStatus.AutoSize = true;
            this.lblCurrentJobStatus.Location = new System.Drawing.Point(15, 41);
            this.lblCurrentJobStatus.Name = "lblCurrentJobStatus";
            this.lblCurrentJobStatus.Size = new System.Drawing.Size(97, 13);
            this.lblCurrentJobStatus.TabIndex = 8;
            this.lblCurrentJobStatus.Text = "Current Job Status:";
            // 
            // lblJobCreationDateTime
            // 
            this.lblJobCreationDateTime.AutoSize = true;
            this.lblJobCreationDateTime.Location = new System.Drawing.Point(15, 18);
            this.lblJobCreationDateTime.Name = "lblJobCreationDateTime";
            this.lblJobCreationDateTime.Size = new System.Drawing.Size(94, 13);
            this.lblJobCreationDateTime.TabIndex = 7;
            this.lblJobCreationDateTime.Text = "Job Lead Created:";
            // 
            // cboJobStatusList
            // 
            this.cboJobStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobStatusList.FormattingEnabled = true;
            this.cboJobStatusList.Location = new System.Drawing.Point(122, 38);
            this.cboJobStatusList.Name = "cboJobStatusList";
            this.cboJobStatusList.Size = new System.Drawing.Size(178, 21);
            this.cboJobStatusList.TabIndex = 6;
            // 
            // dateTimeCreationDateTime
            // 
            this.dateTimeCreationDateTime.CustomFormat = "dd MMM yyyy - HH:mm:ss";
            this.dateTimeCreationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreationDateTime.Location = new System.Drawing.Point(122, 12);
            this.dateTimeCreationDateTime.Name = "dateTimeCreationDateTime";
            this.dateTimeCreationDateTime.Size = new System.Drawing.Size(155, 20);
            this.dateTimeCreationDateTime.TabIndex = 5;
            // 
            // btnCloseJobLead
            // 
            this.btnCloseJobLead.Location = new System.Drawing.Point(301, 405);
            this.btnCloseJobLead.Name = "btnCloseJobLead";
            this.btnCloseJobLead.Size = new System.Drawing.Size(108, 23);
            this.btnCloseJobLead.TabIndex = 9;
            this.btnCloseJobLead.Text = "Update and Close";
            this.btnCloseJobLead.UseVisualStyleBackColor = true;
            this.btnCloseJobLead.Click += new System.EventHandler(this.btnCloseJobLead_Click);
            // 
            // btnShowAgency
            // 
            this.btnShowAgency.Location = new System.Drawing.Point(487, 65);
            this.btnShowAgency.Name = "btnShowAgency";
            this.btnShowAgency.Size = new System.Drawing.Size(135, 23);
            this.btnShowAgency.TabIndex = 18;
            this.btnShowAgency.Text = "Show Agency";
            this.btnShowAgency.UseVisualStyleBackColor = true;
            this.btnShowAgency.Click += new System.EventHandler(this.btnShowAgency_Click);
            // 
            // lblAgencyList
            // 
            this.lblAgencyList.AutoSize = true;
            this.lblAgencyList.Location = new System.Drawing.Point(15, 68);
            this.lblAgencyList.Name = "lblAgencyList";
            this.lblAgencyList.Size = new System.Drawing.Size(77, 13);
            this.lblAgencyList.TabIndex = 17;
            this.lblAgencyList.Text = "Agency Name:";
            // 
            // cboAgencyNames
            // 
            this.cboAgencyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgencyNames.FormattingEnabled = true;
            this.cboAgencyNames.Location = new System.Drawing.Point(122, 65);
            this.cboAgencyNames.Name = "cboAgencyNames";
            this.cboAgencyNames.Size = new System.Drawing.Size(349, 21);
            this.cboAgencyNames.TabIndex = 16;
            this.cboAgencyNames.SelectionChangeCommitted += new System.EventHandler(this.cboAgencyNames_SelectionChangeCommitted);
            // 
            // btnShowEmployer
            // 
            this.btnShowEmployer.Location = new System.Drawing.Point(487, 92);
            this.btnShowEmployer.Name = "btnShowEmployer";
            this.btnShowEmployer.Size = new System.Drawing.Size(135, 23);
            this.btnShowEmployer.TabIndex = 21;
            this.btnShowEmployer.Text = "Show Employer";
            this.btnShowEmployer.UseVisualStyleBackColor = true;
            this.btnShowEmployer.Click += new System.EventHandler(this.btnShowEmployer_Click);
            // 
            // lblEmployersList
            // 
            this.lblEmployersList.AutoSize = true;
            this.lblEmployersList.Location = new System.Drawing.Point(15, 95);
            this.lblEmployersList.Name = "lblEmployersList";
            this.lblEmployersList.Size = new System.Drawing.Size(84, 13);
            this.lblEmployersList.TabIndex = 20;
            this.lblEmployersList.Text = "Employer Name:";
            // 
            // cboEmployerNames
            // 
            this.cboEmployerNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployerNames.FormattingEnabled = true;
            this.cboEmployerNames.Location = new System.Drawing.Point(122, 92);
            this.cboEmployerNames.Name = "cboEmployerNames";
            this.cboEmployerNames.Size = new System.Drawing.Size(349, 21);
            this.cboEmployerNames.TabIndex = 19;
            this.cboEmployerNames.SelectionChangeCommitted += new System.EventHandler(this.cboEmployerNames_SelectionChangeCommitted);
            // 
            // btnShowEmployerContact
            // 
            this.btnShowEmployerContact.Location = new System.Drawing.Point(487, 144);
            this.btnShowEmployerContact.Name = "btnShowEmployerContact";
            this.btnShowEmployerContact.Size = new System.Drawing.Size(135, 23);
            this.btnShowEmployerContact.TabIndex = 27;
            this.btnShowEmployerContact.Text = "Show Employer Contact";
            this.btnShowEmployerContact.UseVisualStyleBackColor = true;
            this.btnShowEmployerContact.Click += new System.EventHandler(this.btnShowEmployerContact_Click);
            // 
            // btnShowAgencyContact
            // 
            this.btnShowAgencyContact.Location = new System.Drawing.Point(487, 119);
            this.btnShowAgencyContact.Name = "btnShowAgencyContact";
            this.btnShowAgencyContact.Size = new System.Drawing.Size(135, 23);
            this.btnShowAgencyContact.TabIndex = 26;
            this.btnShowAgencyContact.Text = "Show Agency Contact";
            this.btnShowAgencyContact.UseVisualStyleBackColor = true;
            this.btnShowAgencyContact.Click += new System.EventHandler(this.btnShowAgencyContact_Click);
            // 
            // lblEmployerContactName
            // 
            this.lblEmployerContactName.AutoSize = true;
            this.lblEmployerContactName.Location = new System.Drawing.Point(15, 149);
            this.lblEmployerContactName.Name = "lblEmployerContactName";
            this.lblEmployerContactName.Size = new System.Drawing.Size(93, 13);
            this.lblEmployerContactName.TabIndex = 25;
            this.lblEmployerContactName.Text = "Employer Contact:";
            // 
            // cboEmployerContactNames
            // 
            this.cboEmployerContactNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployerContactNames.FormattingEnabled = true;
            this.cboEmployerContactNames.Location = new System.Drawing.Point(122, 146);
            this.cboEmployerContactNames.Name = "cboEmployerContactNames";
            this.cboEmployerContactNames.Size = new System.Drawing.Size(349, 21);
            this.cboEmployerContactNames.TabIndex = 24;
            this.cboEmployerContactNames.SelectionChangeCommitted += new System.EventHandler(this.cboEmployerContactNames_SelectionChangeCommitted);
            // 
            // lblAgencyContactName
            // 
            this.lblAgencyContactName.AutoSize = true;
            this.lblAgencyContactName.Location = new System.Drawing.Point(15, 122);
            this.lblAgencyContactName.Name = "lblAgencyContactName";
            this.lblAgencyContactName.Size = new System.Drawing.Size(86, 13);
            this.lblAgencyContactName.TabIndex = 23;
            this.lblAgencyContactName.Text = "Agency Contact:";
            // 
            // cboAgencyContactNames
            // 
            this.cboAgencyContactNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgencyContactNames.FormattingEnabled = true;
            this.cboAgencyContactNames.Location = new System.Drawing.Point(122, 119);
            this.cboAgencyContactNames.Name = "cboAgencyContactNames";
            this.cboAgencyContactNames.Size = new System.Drawing.Size(349, 21);
            this.cboAgencyContactNames.TabIndex = 22;
            this.cboAgencyContactNames.SelectionChangeCommitted += new System.EventHandler(this.cboAgencyContactNames_SelectionChangeCommitted);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(15, 179);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 13);
            this.lblJobTitle.TabIndex = 28;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // txtBoxJobTitle
            // 
            this.txtBoxJobTitle.Location = new System.Drawing.Point(122, 176);
            this.txtBoxJobTitle.Name = "txtBoxJobTitle";
            this.txtBoxJobTitle.Size = new System.Drawing.Size(349, 20);
            this.txtBoxJobTitle.TabIndex = 29;
            // 
            // txtBoxLeadSource
            // 
            this.txtBoxLeadSource.Location = new System.Drawing.Point(122, 202);
            this.txtBoxLeadSource.Name = "txtBoxLeadSource";
            this.txtBoxLeadSource.Size = new System.Drawing.Size(349, 20);
            this.txtBoxLeadSource.TabIndex = 31;
            // 
            // lblLeadSource
            // 
            this.lblLeadSource.AutoSize = true;
            this.lblLeadSource.Location = new System.Drawing.Point(15, 205);
            this.lblLeadSource.Name = "lblLeadSource";
            this.lblLeadSource.Size = new System.Drawing.Size(44, 13);
            this.lblLeadSource.TabIndex = 30;
            this.lblLeadSource.Text = "Source:";
            // 
            // txtBoxApplicationDocLocation
            // 
            this.txtBoxApplicationDocLocation.Location = new System.Drawing.Point(122, 228);
            this.txtBoxApplicationDocLocation.Name = "txtBoxApplicationDocLocation";
            this.txtBoxApplicationDocLocation.Size = new System.Drawing.Size(349, 20);
            this.txtBoxApplicationDocLocation.TabIndex = 33;
            // 
            // lblCVorApplicationLocation
            // 
            this.lblCVorApplicationLocation.AutoSize = true;
            this.lblCVorApplicationLocation.Location = new System.Drawing.Point(15, 231);
            this.lblCVorApplicationLocation.Name = "lblCVorApplicationLocation";
            this.lblCVorApplicationLocation.Size = new System.Drawing.Size(129, 13);
            this.lblCVorApplicationLocation.TabIndex = 32;
            this.lblCVorApplicationLocation.Text = "Application Doc Location:";
            // 
            // txtBoxCoverLetterLocation
            // 
            this.txtBoxCoverLetterLocation.Location = new System.Drawing.Point(122, 254);
            this.txtBoxCoverLetterLocation.Name = "txtBoxCoverLetterLocation";
            this.txtBoxCoverLetterLocation.Size = new System.Drawing.Size(349, 20);
            this.txtBoxCoverLetterLocation.TabIndex = 35;
            // 
            // lblCoverLetterDocLocation
            // 
            this.lblCoverLetterDocLocation.AutoSize = true;
            this.lblCoverLetterDocLocation.Location = new System.Drawing.Point(15, 257);
            this.lblCoverLetterDocLocation.Name = "lblCoverLetterDocLocation";
            this.lblCoverLetterDocLocation.Size = new System.Drawing.Size(112, 13);
            this.lblCoverLetterDocLocation.TabIndex = 34;
            this.lblCoverLetterDocLocation.Text = "Cover Letter Location:";
            // 
            // txtBoxRefOne
            // 
            this.txtBoxRefOne.Location = new System.Drawing.Point(122, 280);
            this.txtBoxRefOne.Name = "txtBoxRefOne";
            this.txtBoxRefOne.Size = new System.Drawing.Size(349, 20);
            this.txtBoxRefOne.TabIndex = 37;
            // 
            // lblRef1
            // 
            this.lblRef1.AutoSize = true;
            this.lblRef1.Location = new System.Drawing.Point(15, 283);
            this.lblRef1.Name = "lblRef1";
            this.lblRef1.Size = new System.Drawing.Size(50, 13);
            this.lblRef1.TabIndex = 36;
            this.lblRef1.Text = "Ref One:";
            // 
            // txtBoxRefTwo
            // 
            this.txtBoxRefTwo.Location = new System.Drawing.Point(122, 306);
            this.txtBoxRefTwo.Name = "txtBoxRefTwo";
            this.txtBoxRefTwo.Size = new System.Drawing.Size(349, 20);
            this.txtBoxRefTwo.TabIndex = 39;
            // 
            // lblRefTwo
            // 
            this.lblRefTwo.AutoSize = true;
            this.lblRefTwo.Location = new System.Drawing.Point(15, 309);
            this.lblRefTwo.Name = "lblRefTwo";
            this.lblRefTwo.Size = new System.Drawing.Size(51, 13);
            this.lblRefTwo.TabIndex = 38;
            this.lblRefTwo.Text = "Ref Two:";
            // 
            // txtBoxRefThree
            // 
            this.txtBoxRefThree.Location = new System.Drawing.Point(122, 332);
            this.txtBoxRefThree.Name = "txtBoxRefThree";
            this.txtBoxRefThree.Size = new System.Drawing.Size(349, 20);
            this.txtBoxRefThree.TabIndex = 41;
            // 
            // lblRefThree
            // 
            this.lblRefThree.AutoSize = true;
            this.lblRefThree.Location = new System.Drawing.Point(15, 335);
            this.lblRefThree.Name = "lblRefThree";
            this.lblRefThree.Size = new System.Drawing.Size(58, 13);
            this.lblRefThree.TabIndex = 40;
            this.lblRefThree.Text = "Ref Three:";
            // 
            // btnNewAgencyBroker
            // 
            this.btnNewAgencyBroker.Location = new System.Drawing.Point(628, 65);
            this.btnNewAgencyBroker.Name = "btnNewAgencyBroker";
            this.btnNewAgencyBroker.Size = new System.Drawing.Size(99, 23);
            this.btnNewAgencyBroker.TabIndex = 42;
            this.btnNewAgencyBroker.Text = "New Agency";
            this.btnNewAgencyBroker.UseVisualStyleBackColor = true;
            this.btnNewAgencyBroker.Click += new System.EventHandler(this.btnNewAgencyBroker_Click);
            // 
            // btnNewEmployerBroker
            // 
            this.btnNewEmployerBroker.Location = new System.Drawing.Point(628, 92);
            this.btnNewEmployerBroker.Name = "btnNewEmployerBroker";
            this.btnNewEmployerBroker.Size = new System.Drawing.Size(99, 23);
            this.btnNewEmployerBroker.TabIndex = 43;
            this.btnNewEmployerBroker.Text = "New Employer";
            this.btnNewEmployerBroker.UseVisualStyleBackColor = true;
            this.btnNewEmployerBroker.Click += new System.EventHandler(this.btnNewEmployerBroker_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel and Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(122, 358);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(122, 23);
            this.btnAddNote.TabIndex = 45;
            this.btnAddNote.Text = "Add and View Notes";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // lblNotesCount
            // 
            this.lblNotesCount.AutoSize = true;
            this.lblNotesCount.Location = new System.Drawing.Point(250, 363);
            this.lblNotesCount.Name = "lblNotesCount";
            this.lblNotesCount.Size = new System.Drawing.Size(104, 13);
            this.lblNotesCount.TabIndex = 46;
            this.lblNotesCount.Text = "<Notes Count Here>";
            // 
            // btnPasteFrmClipboard
            // 
            this.btnPasteFrmClipboard.Location = new System.Drawing.Point(487, 200);
            this.btnPasteFrmClipboard.Name = "btnPasteFrmClipboard";
            this.btnPasteFrmClipboard.Size = new System.Drawing.Size(135, 23);
            this.btnPasteFrmClipboard.TabIndex = 48;
            this.btnPasteFrmClipboard.Text = "Screen Grab";
            this.btnPasteFrmClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFrmClipboard.Click += new System.EventHandler(this.btnPasteFrmClipboard_Click);
            // 
            // frmJobLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 440);
            this.Controls.Add(this.btnPasteFrmClipboard);
            this.Controls.Add(this.lblNotesCount);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewEmployerBroker);
            this.Controls.Add(this.btnNewAgencyBroker);
            this.Controls.Add(this.txtBoxRefThree);
            this.Controls.Add(this.lblRefThree);
            this.Controls.Add(this.txtBoxRefTwo);
            this.Controls.Add(this.lblRefTwo);
            this.Controls.Add(this.txtBoxRefOne);
            this.Controls.Add(this.lblRef1);
            this.Controls.Add(this.txtBoxCoverLetterLocation);
            this.Controls.Add(this.lblCoverLetterDocLocation);
            this.Controls.Add(this.txtBoxApplicationDocLocation);
            this.Controls.Add(this.lblCVorApplicationLocation);
            this.Controls.Add(this.txtBoxLeadSource);
            this.Controls.Add(this.lblLeadSource);
            this.Controls.Add(this.txtBoxJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.btnShowEmployerContact);
            this.Controls.Add(this.btnShowAgencyContact);
            this.Controls.Add(this.lblEmployerContactName);
            this.Controls.Add(this.cboEmployerContactNames);
            this.Controls.Add(this.lblAgencyContactName);
            this.Controls.Add(this.cboAgencyContactNames);
            this.Controls.Add(this.btnShowEmployer);
            this.Controls.Add(this.lblEmployersList);
            this.Controls.Add(this.cboEmployerNames);
            this.Controls.Add(this.btnShowAgency);
            this.Controls.Add(this.lblAgencyList);
            this.Controls.Add(this.cboAgencyNames);
            this.Controls.Add(this.btnCloseJobLead);
            this.Controls.Add(this.lblCurrentJobStatus);
            this.Controls.Add(this.lblJobCreationDateTime);
            this.Controls.Add(this.cboJobStatusList);
            this.Controls.Add(this.dateTimeCreationDateTime);
            this.Name = "frmJobLead";
            this.Text = "frmJobLead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentJobStatus;
        private System.Windows.Forms.Label lblJobCreationDateTime;
        private System.Windows.Forms.ComboBox cboJobStatusList;
        private System.Windows.Forms.DateTimePicker dateTimeCreationDateTime;
        private System.Windows.Forms.Button btnCloseJobLead;
        private System.Windows.Forms.Button btnShowAgency;
        private System.Windows.Forms.Label lblAgencyList;
        private System.Windows.Forms.ComboBox cboAgencyNames;
        private System.Windows.Forms.Button btnShowEmployer;
        private System.Windows.Forms.Label lblEmployersList;
        private System.Windows.Forms.ComboBox cboEmployerNames;
        private System.Windows.Forms.Button btnShowEmployerContact;
        private System.Windows.Forms.Button btnShowAgencyContact;
        private System.Windows.Forms.Label lblEmployerContactName;
        private System.Windows.Forms.ComboBox cboEmployerContactNames;
        private System.Windows.Forms.Label lblAgencyContactName;
        private System.Windows.Forms.ComboBox cboAgencyContactNames;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtBoxJobTitle;
        private System.Windows.Forms.TextBox txtBoxLeadSource;
        private System.Windows.Forms.Label lblLeadSource;
        private System.Windows.Forms.TextBox txtBoxApplicationDocLocation;
        private System.Windows.Forms.Label lblCVorApplicationLocation;
        private System.Windows.Forms.TextBox txtBoxCoverLetterLocation;
        private System.Windows.Forms.Label lblCoverLetterDocLocation;
        private System.Windows.Forms.TextBox txtBoxRefOne;
        private System.Windows.Forms.Label lblRef1;
        private System.Windows.Forms.TextBox txtBoxRefTwo;
        private System.Windows.Forms.Label lblRefTwo;
        private System.Windows.Forms.TextBox txtBoxRefThree;
        private System.Windows.Forms.Label lblRefThree;
        private System.Windows.Forms.Button btnNewAgencyBroker;
        private System.Windows.Forms.Button btnNewEmployerBroker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label lblNotesCount;
        private System.Windows.Forms.Button btnPasteFrmClipboard;
    }
}