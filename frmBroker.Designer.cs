namespace JobApplication
{
    partial class frmBroker
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
            this.btnUpdateClose = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.lstBoxAssociatedBrokers = new System.Windows.Forms.ListBox();
            this.lstBoxBrokerContacts = new System.Windows.Forms.ListBox();
            this.lblBrokerContacts = new System.Windows.Forms.Label();
            this.lblAssociatedBrokers = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnAddBroker = new System.Windows.Forms.Button();
            this.rTxtBoxBrokerAddress = new System.Windows.Forms.RichTextBox();
            this.lblBrokerAddress = new System.Windows.Forms.Label();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.txtBoxBrokerName = new System.Windows.Forms.TextBox();
            this.lblBrokerName = new System.Windows.Forms.Label();
            this.lblLandLinePhoneNo = new System.Windows.Forms.Label();
            this.txtBoxLandLinePhoneNo = new System.Windows.Forms.TextBox();
            this.txtBoxWebSite = new System.Windows.Forms.TextBox();
            this.lblWebSite = new System.Windows.Forms.Label();
            this.pnlBrokerType = new System.Windows.Forms.Panel();
            this.rButtonEmployerBroker = new System.Windows.Forms.RadioButton();
            this.rButtonAgencyBroker = new System.Windows.Forms.RadioButton();
            this.pnlUnassociatedBrokers = new System.Windows.Forms.Panel();
            this.btnAssociateBroker = new System.Windows.Forms.Button();
            this.lstBoxUnassociatedBrokers = new System.Windows.Forms.ListBox();
            this.pnlBrokerType.SuspendLayout();
            this.pnlUnassociatedBrokers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateClose
            // 
            this.btnUpdateClose.Location = new System.Drawing.Point(272, 522);
            this.btnUpdateClose.Name = "btnUpdateClose";
            this.btnUpdateClose.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateClose.TabIndex = 0;
            this.btnUpdateClose.Text = "Update and Close";
            this.btnUpdateClose.UseVisualStyleBackColor = true;
            this.btnUpdateClose.Click += new System.EventHandler(this.btnUpdateClose_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(442, 522);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(102, 23);
            this.btnCancelClose.TabIndex = 1;
            this.btnCancelClose.Text = "Cancel and Close";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // lstBoxAssociatedBrokers
            // 
            this.lstBoxAssociatedBrokers.FormattingEnabled = true;
            this.lstBoxAssociatedBrokers.Location = new System.Drawing.Point(7, 163);
            this.lstBoxAssociatedBrokers.Name = "lstBoxAssociatedBrokers";
            this.lstBoxAssociatedBrokers.Size = new System.Drawing.Size(186, 95);
            this.lstBoxAssociatedBrokers.TabIndex = 2;
            // 
            // lstBoxBrokerContacts
            // 
            this.lstBoxBrokerContacts.FormattingEnabled = true;
            this.lstBoxBrokerContacts.Location = new System.Drawing.Point(7, 317);
            this.lstBoxBrokerContacts.Name = "lstBoxBrokerContacts";
            this.lstBoxBrokerContacts.Size = new System.Drawing.Size(186, 95);
            this.lstBoxBrokerContacts.TabIndex = 3;
            // 
            // lblBrokerContacts
            // 
            this.lblBrokerContacts.AutoSize = true;
            this.lblBrokerContacts.Location = new System.Drawing.Point(7, 301);
            this.lblBrokerContacts.Name = "lblBrokerContacts";
            this.lblBrokerContacts.Size = new System.Drawing.Size(49, 13);
            this.lblBrokerContacts.TabIndex = 4;
            this.lblBrokerContacts.Text = "Contacts";
            // 
            // lblAssociatedBrokers
            // 
            this.lblAssociatedBrokers.AutoSize = true;
            this.lblAssociatedBrokers.Location = new System.Drawing.Point(7, 147);
            this.lblAssociatedBrokers.Name = "lblAssociatedBrokers";
            this.lblAssociatedBrokers.Size = new System.Drawing.Size(98, 13);
            this.lblAssociatedBrokers.TabIndex = 5;
            this.lblAssociatedBrokers.Text = "Associated Brokers";
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(208, 328);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(84, 23);
            this.btnEditContact.TabIndex = 6;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(208, 357);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(84, 23);
            this.btnNewContact.TabIndex = 7;
            this.btnNewContact.Text = "New Contact";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnAddBroker
            // 
            this.btnAddBroker.Location = new System.Drawing.Point(199, 177);
            this.btnAddBroker.Name = "btnAddBroker";
            this.btnAddBroker.Size = new System.Drawing.Size(84, 23);
            this.btnAddBroker.TabIndex = 8;
            this.btnAddBroker.Text = "Add Broker";
            this.btnAddBroker.UseVisualStyleBackColor = true;
            this.btnAddBroker.Click += new System.EventHandler(this.btnAddBroker_Click);
            // 
            // rTxtBoxBrokerAddress
            // 
            this.rTxtBoxBrokerAddress.Enabled = false;
            this.rTxtBoxBrokerAddress.Location = new System.Drawing.Point(364, 163);
            this.rTxtBoxBrokerAddress.Name = "rTxtBoxBrokerAddress";
            this.rTxtBoxBrokerAddress.Size = new System.Drawing.Size(249, 95);
            this.rTxtBoxBrokerAddress.TabIndex = 9;
            this.rTxtBoxBrokerAddress.Text = "";
            // 
            // lblBrokerAddress
            // 
            this.lblBrokerAddress.AutoSize = true;
            this.lblBrokerAddress.Location = new System.Drawing.Point(372, 147);
            this.lblBrokerAddress.Name = "lblBrokerAddress";
            this.lblBrokerAddress.Size = new System.Drawing.Size(45, 13);
            this.lblBrokerAddress.TabIndex = 10;
            this.lblBrokerAddress.Text = "Address";
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Location = new System.Drawing.Point(629, 171);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(87, 23);
            this.btnEditAddress.TabIndex = 11;
            this.btnEditAddress.Text = "Edit Address";
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Location = new System.Drawing.Point(629, 200);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(87, 23);
            this.btnNewAddress.TabIndex = 12;
            this.btnNewAddress.Text = "New Address";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new System.EventHandler(this.btnNewAddress_Click);
            // 
            // txtBoxBrokerName
            // 
            this.txtBoxBrokerName.Location = new System.Drawing.Point(53, 6);
            this.txtBoxBrokerName.Name = "txtBoxBrokerName";
            this.txtBoxBrokerName.Size = new System.Drawing.Size(342, 20);
            this.txtBoxBrokerName.TabIndex = 13;
            // 
            // lblBrokerName
            // 
            this.lblBrokerName.AutoSize = true;
            this.lblBrokerName.Location = new System.Drawing.Point(9, 9);
            this.lblBrokerName.Name = "lblBrokerName";
            this.lblBrokerName.Size = new System.Drawing.Size(38, 13);
            this.lblBrokerName.TabIndex = 14;
            this.lblBrokerName.Text = "Name:";
            // 
            // lblLandLinePhoneNo
            // 
            this.lblLandLinePhoneNo.AutoSize = true;
            this.lblLandLinePhoneNo.Location = new System.Drawing.Point(12, 38);
            this.lblLandLinePhoneNo.Name = "lblLandLinePhoneNo";
            this.lblLandLinePhoneNo.Size = new System.Drawing.Size(77, 13);
            this.lblLandLinePhoneNo.TabIndex = 15;
            this.lblLandLinePhoneNo.Text = "Land Line No.:";
            // 
            // txtBoxLandLinePhoneNo
            // 
            this.txtBoxLandLinePhoneNo.Location = new System.Drawing.Point(95, 35);
            this.txtBoxLandLinePhoneNo.Name = "txtBoxLandLinePhoneNo";
            this.txtBoxLandLinePhoneNo.Size = new System.Drawing.Size(300, 20);
            this.txtBoxLandLinePhoneNo.TabIndex = 16;
            // 
            // txtBoxWebSite
            // 
            this.txtBoxWebSite.Location = new System.Drawing.Point(67, 69);
            this.txtBoxWebSite.Name = "txtBoxWebSite";
            this.txtBoxWebSite.Size = new System.Drawing.Size(328, 20);
            this.txtBoxWebSite.TabIndex = 17;
            // 
            // lblWebSite
            // 
            this.lblWebSite.AutoSize = true;
            this.lblWebSite.Location = new System.Drawing.Point(7, 72);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(54, 13);
            this.lblWebSite.TabIndex = 18;
            this.lblWebSite.Text = "Web Site:";
            // 
            // pnlBrokerType
            // 
            this.pnlBrokerType.Controls.Add(this.rButtonEmployerBroker);
            this.pnlBrokerType.Controls.Add(this.rButtonAgencyBroker);
            this.pnlBrokerType.Location = new System.Drawing.Point(413, 12);
            this.pnlBrokerType.Name = "pnlBrokerType";
            this.pnlBrokerType.Size = new System.Drawing.Size(90, 63);
            this.pnlBrokerType.TabIndex = 19;
            // 
            // rButtonEmployerBroker
            // 
            this.rButtonEmployerBroker.AutoSize = true;
            this.rButtonEmployerBroker.Location = new System.Drawing.Point(13, 35);
            this.rButtonEmployerBroker.Name = "rButtonEmployerBroker";
            this.rButtonEmployerBroker.Size = new System.Drawing.Size(68, 17);
            this.rButtonEmployerBroker.TabIndex = 1;
            this.rButtonEmployerBroker.TabStop = true;
            this.rButtonEmployerBroker.Text = "Employer";
            this.rButtonEmployerBroker.UseVisualStyleBackColor = true;
            this.rButtonEmployerBroker.CheckedChanged += new System.EventHandler(this.rButtonEmployerBroker_CheckedChanged);
            // 
            // rButtonAgencyBroker
            // 
            this.rButtonAgencyBroker.AutoSize = true;
            this.rButtonAgencyBroker.Location = new System.Drawing.Point(13, 12);
            this.rButtonAgencyBroker.Name = "rButtonAgencyBroker";
            this.rButtonAgencyBroker.Size = new System.Drawing.Size(61, 17);
            this.rButtonAgencyBroker.TabIndex = 0;
            this.rButtonAgencyBroker.TabStop = true;
            this.rButtonAgencyBroker.Text = "Agency";
            this.rButtonAgencyBroker.UseVisualStyleBackColor = true;
            this.rButtonAgencyBroker.CheckedChanged += new System.EventHandler(this.rButtonAgencyBroker_CheckedChanged);
            // 
            // pnlUnassociatedBrokers
            // 
            this.pnlUnassociatedBrokers.Controls.Add(this.btnAssociateBroker);
            this.pnlUnassociatedBrokers.Controls.Add(this.lstBoxUnassociatedBrokers);
            this.pnlUnassociatedBrokers.Location = new System.Drawing.Point(389, 317);
            this.pnlUnassociatedBrokers.Name = "pnlUnassociatedBrokers";
            this.pnlUnassociatedBrokers.Size = new System.Drawing.Size(200, 140);
            this.pnlUnassociatedBrokers.TabIndex = 2;
            // 
            // btnAssociateBroker
            // 
            this.btnAssociateBroker.Location = new System.Drawing.Point(62, 114);
            this.btnAssociateBroker.Name = "btnAssociateBroker";
            this.btnAssociateBroker.Size = new System.Drawing.Size(84, 23);
            this.btnAssociateBroker.TabIndex = 21;
            this.btnAssociateBroker.Text = "Add Broker";
            this.btnAssociateBroker.UseVisualStyleBackColor = true;
            this.btnAssociateBroker.Click += new System.EventHandler(this.btnAssociateBroker_Click);
            // 
            // lstBoxUnassociatedBrokers
            // 
            this.lstBoxUnassociatedBrokers.FormattingEnabled = true;
            this.lstBoxUnassociatedBrokers.Location = new System.Drawing.Point(3, 3);
            this.lstBoxUnassociatedBrokers.Name = "lstBoxUnassociatedBrokers";
            this.lstBoxUnassociatedBrokers.Size = new System.Drawing.Size(194, 108);
            this.lstBoxUnassociatedBrokers.TabIndex = 20;
            // 
            // frmBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 557);
            this.Controls.Add(this.pnlUnassociatedBrokers);
            this.Controls.Add(this.pnlBrokerType);
            this.Controls.Add(this.lblWebSite);
            this.Controls.Add(this.txtBoxWebSite);
            this.Controls.Add(this.txtBoxLandLinePhoneNo);
            this.Controls.Add(this.lblLandLinePhoneNo);
            this.Controls.Add(this.lblBrokerName);
            this.Controls.Add(this.txtBoxBrokerName);
            this.Controls.Add(this.btnNewAddress);
            this.Controls.Add(this.btnEditAddress);
            this.Controls.Add(this.lblBrokerAddress);
            this.Controls.Add(this.rTxtBoxBrokerAddress);
            this.Controls.Add(this.btnAddBroker);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.lblAssociatedBrokers);
            this.Controls.Add(this.lblBrokerContacts);
            this.Controls.Add(this.lstBoxBrokerContacts);
            this.Controls.Add(this.lstBoxAssociatedBrokers);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnUpdateClose);
            this.Name = "frmBroker";
            this.Text = "frmBroker";
            this.pnlBrokerType.ResumeLayout(false);
            this.pnlBrokerType.PerformLayout();
            this.pnlUnassociatedBrokers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClose;
        private System.Windows.Forms.Button btnCancelClose;
        private System.Windows.Forms.ListBox lstBoxAssociatedBrokers;
        private System.Windows.Forms.ListBox lstBoxBrokerContacts;
        private System.Windows.Forms.Label lblBrokerContacts;
        private System.Windows.Forms.Label lblAssociatedBrokers;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnAddBroker;
        private System.Windows.Forms.RichTextBox rTxtBoxBrokerAddress;
        private System.Windows.Forms.Label lblBrokerAddress;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button btnNewAddress;
        private System.Windows.Forms.TextBox txtBoxBrokerName;
        private System.Windows.Forms.Label lblBrokerName;
        private System.Windows.Forms.Label lblLandLinePhoneNo;
        private System.Windows.Forms.TextBox txtBoxLandLinePhoneNo;
        private System.Windows.Forms.TextBox txtBoxWebSite;
        private System.Windows.Forms.Label lblWebSite;
        private System.Windows.Forms.Panel pnlBrokerType;
        private System.Windows.Forms.RadioButton rButtonEmployerBroker;
        private System.Windows.Forms.RadioButton rButtonAgencyBroker;
        private System.Windows.Forms.Panel pnlUnassociatedBrokers;
        private System.Windows.Forms.Button btnAssociateBroker;
        private System.Windows.Forms.ListBox lstBoxUnassociatedBrokers;
    }
}