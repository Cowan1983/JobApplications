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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
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
            this.btnGetJobLeads.Location = new System.Drawing.Point(12, 12);
            this.btnGetJobLeads.Name = "btnGetJobLeads";
            this.btnGetJobLeads.Size = new System.Drawing.Size(98, 23);
            this.btnGetJobLeads.TabIndex = 2;
            this.btnGetJobLeads.Text = "Interogate Data";
            this.btnGetJobLeads.UseVisualStyleBackColor = true;
            this.btnGetJobLeads.Click += new System.EventHandler(this.btnGetJobLeads_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(998, 293);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // btnNewJobLead
            // 
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
            this.btnNewBroker.Location = new System.Drawing.Point(12, 369);
            this.btnNewBroker.Name = "btnNewBroker";
            this.btnNewBroker.Size = new System.Drawing.Size(99, 23);
            this.btnNewBroker.TabIndex = 7;
            this.btnNewBroker.Text = "New Broker";
            this.btnNewBroker.UseVisualStyleBackColor = true;
            this.btnNewBroker.Click += new System.EventHandler(this.btnNewBroker_Click);
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 401);
            this.Controls.Add(this.btnNewBroker);
            this.Controls.Add(this.btnNewJobLead);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGetJobLeads);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFrontPage";
            this.Text = "Front Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetJobLeads;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNewJobLead;
        private System.Windows.Forms.Button btnNewBroker;
    }
}

