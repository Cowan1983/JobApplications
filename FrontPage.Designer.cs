namespace JobApplication
{
    partial class frmFrontPage
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
            this.btnGetJobLeads = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnNewJobLead = new System.Windows.Forms.Button();
            this.btnNewBroker = new System.Windows.Forms.Button();
            this.pnlFilterOptions = new System.Windows.Forms.Panel();
            this.rBtnJobAgent = new System.Windows.Forms.RadioButton();
            this.pnlStatusSearchOptions = new System.Windows.Forms.Panel();
            this.chkListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.btnSearchJobLeads = new System.Windows.Forms.Button();
            this.pnlJobTitleSearchOptions = new System.Windows.Forms.Panel();
            this.txtBoxSearchText = new System.Windows.Forms.TextBox();
            this.pnlDateSearchOptions = new System.Windows.Forms.Panel();
            this.lblDateSearchTo = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.rBtnJobReference = new System.Windows.Forms.RadioButton();
            this.rBtnJobStatus = new System.Windows.Forms.RadioButton();
            this.rBtnJobDate = new System.Windows.Forms.RadioButton();
            this.rBtnJobTitle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlFilterOptions.SuspendLayout();
            this.pnlStatusSearchOptions.SuspendLayout();
            this.pnlJobTitleSearchOptions.SuspendLayout();
            this.pnlDateSearchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(473, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetJobLeads
            // 
            this.btnGetJobLeads.Location = new System.Drawing.Point(551, 50);
            this.btnGetJobLeads.Name = "btnGetJobLeads";
            this.btnGetJobLeads.Size = new System.Drawing.Size(98, 23);
            this.btnGetJobLeads.TabIndex = 2;
            this.btnGetJobLeads.Text = "Reset Data";
            this.btnGetJobLeads.UseVisualStyleBackColor = true;
            this.btnGetJobLeads.Click += new System.EventHandler(this.btnGetJobLeads_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 165);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(998, 169);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // btnNewJobLead
            // 
            this.btnNewJobLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewJobLead.Location = new System.Drawing.Point(12, 340);
            this.btnNewJobLead.Name = "btnNewJobLead";
            this.btnNewJobLead.Size = new System.Drawing.Size(99, 23);
            this.btnNewJobLead.TabIndex = 5;
            this.btnNewJobLead.Text = "New Job Lead";
            this.btnNewJobLead.UseVisualStyleBackColor = true;
            this.btnNewJobLead.Click += new System.EventHandler(this.btnNewJobLead_Click);
            // 
            // btnNewBroker
            // 
            this.btnNewBroker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewBroker.Location = new System.Drawing.Point(12, 369);
            this.btnNewBroker.Name = "btnNewBroker";
            this.btnNewBroker.Size = new System.Drawing.Size(99, 23);
            this.btnNewBroker.TabIndex = 7;
            this.btnNewBroker.Text = "New Broker";
            this.btnNewBroker.UseVisualStyleBackColor = true;
            this.btnNewBroker.Click += new System.EventHandler(this.btnNewBroker_Click);
            // 
            // pnlFilterOptions
            // 
            this.pnlFilterOptions.Controls.Add(this.rBtnJobAgent);
            this.pnlFilterOptions.Controls.Add(this.pnlStatusSearchOptions);
            this.pnlFilterOptions.Controls.Add(this.btnSearchJobLeads);
            this.pnlFilterOptions.Controls.Add(this.pnlJobTitleSearchOptions);
            this.pnlFilterOptions.Controls.Add(this.pnlDateSearchOptions);
            this.pnlFilterOptions.Controls.Add(this.rBtnJobReference);
            this.pnlFilterOptions.Controls.Add(this.rBtnJobStatus);
            this.pnlFilterOptions.Controls.Add(this.btnGetJobLeads);
            this.pnlFilterOptions.Controls.Add(this.rBtnJobDate);
            this.pnlFilterOptions.Controls.Add(this.rBtnJobTitle);
            this.pnlFilterOptions.Location = new System.Drawing.Point(12, 12);
            this.pnlFilterOptions.Name = "pnlFilterOptions";
            this.pnlFilterOptions.Size = new System.Drawing.Size(659, 147);
            this.pnlFilterOptions.TabIndex = 9;
            // 
            // rBtnJobAgent
            // 
            this.rBtnJobAgent.AutoSize = true;
            this.rBtnJobAgent.Location = new System.Drawing.Point(8, 102);
            this.rBtnJobAgent.Name = "rBtnJobAgent";
            this.rBtnJobAgent.Size = new System.Drawing.Size(101, 17);
            this.rBtnJobAgent.TabIndex = 6;
            this.rBtnJobAgent.Text = "Agent/Employer";
            this.rBtnJobAgent.UseVisualStyleBackColor = true;
            this.rBtnJobAgent.Click += new System.EventHandler(this.rBtnJobAgent_Click);
            // 
            // pnlStatusSearchOptions
            // 
            this.pnlStatusSearchOptions.Controls.Add(this.chkListBoxStatus);
            this.pnlStatusSearchOptions.Location = new System.Drawing.Point(109, 0);
            this.pnlStatusSearchOptions.Name = "pnlStatusSearchOptions";
            this.pnlStatusSearchOptions.Size = new System.Drawing.Size(276, 144);
            this.pnlStatusSearchOptions.TabIndex = 4;
            // 
            // chkListBoxStatus
            // 
            this.chkListBoxStatus.CheckOnClick = true;
            this.chkListBoxStatus.FormattingEnabled = true;
            this.chkListBoxStatus.Location = new System.Drawing.Point(3, 3);
            this.chkListBoxStatus.Name = "chkListBoxStatus";
            this.chkListBoxStatus.Size = new System.Drawing.Size(264, 139);
            this.chkListBoxStatus.TabIndex = 0;
            // 
            // btnSearchJobLeads
            // 
            this.btnSearchJobLeads.Location = new System.Drawing.Point(461, 50);
            this.btnSearchJobLeads.Name = "btnSearchJobLeads";
            this.btnSearchJobLeads.Size = new System.Drawing.Size(75, 23);
            this.btnSearchJobLeads.TabIndex = 1;
            this.btnSearchJobLeads.Text = "Search";
            this.btnSearchJobLeads.UseVisualStyleBackColor = true;
            this.btnSearchJobLeads.Click += new System.EventHandler(this.btnSearchJobLeads_Click);
            // 
            // pnlJobTitleSearchOptions
            // 
            this.pnlJobTitleSearchOptions.Controls.Add(this.txtBoxSearchText);
            this.pnlJobTitleSearchOptions.Location = new System.Drawing.Point(111, 3);
            this.pnlJobTitleSearchOptions.Name = "pnlJobTitleSearchOptions";
            this.pnlJobTitleSearchOptions.Size = new System.Drawing.Size(329, 34);
            this.pnlJobTitleSearchOptions.TabIndex = 1;
            // 
            // txtBoxSearchText
            // 
            this.txtBoxSearchText.Location = new System.Drawing.Point(3, 3);
            this.txtBoxSearchText.Name = "txtBoxSearchText";
            this.txtBoxSearchText.Size = new System.Drawing.Size(311, 20);
            this.txtBoxSearchText.TabIndex = 0;
            // 
            // pnlDateSearchOptions
            // 
            this.pnlDateSearchOptions.Controls.Add(this.lblDateSearchTo);
            this.pnlDateSearchOptions.Controls.Add(this.dateTimePickerEndDate);
            this.pnlDateSearchOptions.Controls.Add(this.dateTimePickerStartDate);
            this.pnlDateSearchOptions.Location = new System.Drawing.Point(108, 27);
            this.pnlDateSearchOptions.Name = "pnlDateSearchOptions";
            this.pnlDateSearchOptions.Size = new System.Drawing.Size(329, 30);
            this.pnlDateSearchOptions.TabIndex = 3;
            // 
            // lblDateSearchTo
            // 
            this.lblDateSearchTo.AutoSize = true;
            this.lblDateSearchTo.Location = new System.Drawing.Point(142, 8);
            this.lblDateSearchTo.Name = "lblDateSearchTo";
            this.lblDateSearchTo.Size = new System.Drawing.Size(26, 13);
            this.lblDateSearchTo.TabIndex = 2;
            this.lblDateSearchTo.Text = "-To-";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(181, 6);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(3, 6);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            // 
            // rBtnJobReference
            // 
            this.rBtnJobReference.AutoSize = true;
            this.rBtnJobReference.Location = new System.Drawing.Point(8, 79);
            this.rBtnJobReference.Name = "rBtnJobReference";
            this.rBtnJobReference.Size = new System.Drawing.Size(95, 17);
            this.rBtnJobReference.TabIndex = 3;
            this.rBtnJobReference.Text = "Job Reference";
            this.rBtnJobReference.UseVisualStyleBackColor = true;
            this.rBtnJobReference.Click += new System.EventHandler(this.rBtnJobReference_Click);
            // 
            // rBtnJobStatus
            // 
            this.rBtnJobStatus.AutoSize = true;
            this.rBtnJobStatus.Location = new System.Drawing.Point(8, 56);
            this.rBtnJobStatus.Name = "rBtnJobStatus";
            this.rBtnJobStatus.Size = new System.Drawing.Size(75, 17);
            this.rBtnJobStatus.TabIndex = 2;
            this.rBtnJobStatus.Text = "Job Status";
            this.rBtnJobStatus.UseVisualStyleBackColor = true;
            this.rBtnJobStatus.Click += new System.EventHandler(this.rBtnJobStatus_Click);
            // 
            // rBtnJobDate
            // 
            this.rBtnJobDate.AutoSize = true;
            this.rBtnJobDate.Location = new System.Drawing.Point(8, 33);
            this.rBtnJobDate.Name = "rBtnJobDate";
            this.rBtnJobDate.Size = new System.Drawing.Size(48, 17);
            this.rBtnJobDate.TabIndex = 1;
            this.rBtnJobDate.Text = "Date";
            this.rBtnJobDate.UseVisualStyleBackColor = true;
            this.rBtnJobDate.Click += new System.EventHandler(this.rBtnJobDate_Click);
            // 
            // rBtnJobTitle
            // 
            this.rBtnJobTitle.AutoSize = true;
            this.rBtnJobTitle.Location = new System.Drawing.Point(8, 10);
            this.rBtnJobTitle.Name = "rBtnJobTitle";
            this.rBtnJobTitle.Size = new System.Drawing.Size(65, 17);
            this.rBtnJobTitle.TabIndex = 0;
            this.rBtnJobTitle.Text = "Job Title";
            this.rBtnJobTitle.UseVisualStyleBackColor = true;
            this.rBtnJobTitle.Click += new System.EventHandler(this.rBtnJobTitle_Click);
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 401);
            this.Controls.Add(this.pnlFilterOptions);
            this.Controls.Add(this.btnNewBroker);
            this.Controls.Add(this.btnNewJobLead);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFrontPage";
            this.Text = "Front Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlFilterOptions.ResumeLayout(false);
            this.pnlFilterOptions.PerformLayout();
            this.pnlStatusSearchOptions.ResumeLayout(false);
            this.pnlJobTitleSearchOptions.ResumeLayout(false);
            this.pnlJobTitleSearchOptions.PerformLayout();
            this.pnlDateSearchOptions.ResumeLayout(false);
            this.pnlDateSearchOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetJobLeads;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNewJobLead;
        private System.Windows.Forms.Button btnNewBroker;
        private System.Windows.Forms.Panel pnlFilterOptions;
        private System.Windows.Forms.Button btnSearchJobLeads;
        private System.Windows.Forms.Panel pnlJobTitleSearchOptions;
        private System.Windows.Forms.TextBox txtBoxSearchText;
        private System.Windows.Forms.Panel pnlDateSearchOptions;
        private System.Windows.Forms.Label lblDateSearchTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.RadioButton rBtnJobReference;
        private System.Windows.Forms.RadioButton rBtnJobStatus;
        private System.Windows.Forms.RadioButton rBtnJobDate;
        private System.Windows.Forms.RadioButton rBtnJobTitle;
        private System.Windows.Forms.Panel pnlStatusSearchOptions;
        private System.Windows.Forms.CheckedListBox chkListBoxStatus;
        private System.Windows.Forms.RadioButton rBtnJobAgent;
    }
}

