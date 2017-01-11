namespace JobApplication
{
    partial class frmAddress
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
            this.btnUpdateCloseAddress = new System.Windows.Forms.Button();
            this.btnCancelCloseAddress = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxAddressPostcode = new System.Windows.Forms.TextBox();
            this.lblAddressPostcode = new System.Windows.Forms.Label();
            this.txtBoxAddressCountry = new System.Windows.Forms.TextBox();
            this.lblAddressCountry = new System.Windows.Forms.Label();
            this.txtBoxAddressRegion = new System.Windows.Forms.TextBox();
            this.lblAddressRegion = new System.Windows.Forms.Label();
            this.txtBoxAddressCity = new System.Windows.Forms.TextBox();
            this.lblAddressCity = new System.Windows.Forms.Label();
            this.rTxtBoxAddressBody = new System.Windows.Forms.RichTextBox();
            this.lblAddressBody = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCloseAddress
            // 
            this.btnUpdateCloseAddress.Location = new System.Drawing.Point(12, 282);
            this.btnUpdateCloseAddress.Name = "btnUpdateCloseAddress";
            this.btnUpdateCloseAddress.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateCloseAddress.TabIndex = 0;
            this.btnUpdateCloseAddress.Text = "Update and Close";
            this.btnUpdateCloseAddress.UseVisualStyleBackColor = true;
            this.btnUpdateCloseAddress.Click += new System.EventHandler(this.btnUpdateCloseAddress_Click);
            // 
            // btnCancelCloseAddress
            // 
            this.btnCancelCloseAddress.Location = new System.Drawing.Point(166, 282);
            this.btnCancelCloseAddress.Name = "btnCancelCloseAddress";
            this.btnCancelCloseAddress.Size = new System.Drawing.Size(103, 23);
            this.btnCancelCloseAddress.TabIndex = 1;
            this.btnCancelCloseAddress.Text = "Cancel and Close";
            this.btnCancelCloseAddress.UseVisualStyleBackColor = true;
            this.btnCancelCloseAddress.Click += new System.EventHandler(this.btnCancelCloseAddress_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxAddressPostcode);
            this.panel1.Controls.Add(this.lblAddressPostcode);
            this.panel1.Controls.Add(this.txtBoxAddressCountry);
            this.panel1.Controls.Add(this.lblAddressCountry);
            this.panel1.Controls.Add(this.txtBoxAddressRegion);
            this.panel1.Controls.Add(this.lblAddressRegion);
            this.panel1.Controls.Add(this.txtBoxAddressCity);
            this.panel1.Controls.Add(this.lblAddressCity);
            this.panel1.Controls.Add(this.rTxtBoxAddressBody);
            this.panel1.Controls.Add(this.lblAddressBody);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 264);
            this.panel1.TabIndex = 2;
            // 
            // txtBoxAddressPostcode
            // 
            this.txtBoxAddressPostcode.Location = new System.Drawing.Point(57, 230);
            this.txtBoxAddressPostcode.Name = "txtBoxAddressPostcode";
            this.txtBoxAddressPostcode.Size = new System.Drawing.Size(224, 20);
            this.txtBoxAddressPostcode.TabIndex = 9;
            // 
            // lblAddressPostcode
            // 
            this.lblAddressPostcode.AutoSize = true;
            this.lblAddressPostcode.Location = new System.Drawing.Point(3, 230);
            this.lblAddressPostcode.Name = "lblAddressPostcode";
            this.lblAddressPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblAddressPostcode.TabIndex = 8;
            this.lblAddressPostcode.Text = "Postcode:";
            // 
            // txtBoxAddressCountry
            // 
            this.txtBoxAddressCountry.Location = new System.Drawing.Point(57, 204);
            this.txtBoxAddressCountry.Name = "txtBoxAddressCountry";
            this.txtBoxAddressCountry.Size = new System.Drawing.Size(224, 20);
            this.txtBoxAddressCountry.TabIndex = 7;
            // 
            // lblAddressCountry
            // 
            this.lblAddressCountry.AutoSize = true;
            this.lblAddressCountry.Location = new System.Drawing.Point(3, 204);
            this.lblAddressCountry.Name = "lblAddressCountry";
            this.lblAddressCountry.Size = new System.Drawing.Size(46, 13);
            this.lblAddressCountry.TabIndex = 6;
            this.lblAddressCountry.Text = "Country:";
            // 
            // txtBoxAddressRegion
            // 
            this.txtBoxAddressRegion.Location = new System.Drawing.Point(57, 178);
            this.txtBoxAddressRegion.Name = "txtBoxAddressRegion";
            this.txtBoxAddressRegion.Size = new System.Drawing.Size(224, 20);
            this.txtBoxAddressRegion.TabIndex = 5;
            // 
            // lblAddressRegion
            // 
            this.lblAddressRegion.AutoSize = true;
            this.lblAddressRegion.Location = new System.Drawing.Point(3, 178);
            this.lblAddressRegion.Name = "lblAddressRegion";
            this.lblAddressRegion.Size = new System.Drawing.Size(44, 13);
            this.lblAddressRegion.TabIndex = 4;
            this.lblAddressRegion.Text = "Region:";
            // 
            // txtBoxAddressCity
            // 
            this.txtBoxAddressCity.Location = new System.Drawing.Point(57, 152);
            this.txtBoxAddressCity.Name = "txtBoxAddressCity";
            this.txtBoxAddressCity.Size = new System.Drawing.Size(224, 20);
            this.txtBoxAddressCity.TabIndex = 3;
            // 
            // lblAddressCity
            // 
            this.lblAddressCity.AutoSize = true;
            this.lblAddressCity.Location = new System.Drawing.Point(3, 152);
            this.lblAddressCity.Name = "lblAddressCity";
            this.lblAddressCity.Size = new System.Drawing.Size(27, 13);
            this.lblAddressCity.TabIndex = 2;
            this.lblAddressCity.Text = "City:";
            // 
            // rTxtBoxAddressBody
            // 
            this.rTxtBoxAddressBody.Location = new System.Drawing.Point(57, 6);
            this.rTxtBoxAddressBody.Name = "rTxtBoxAddressBody";
            this.rTxtBoxAddressBody.Size = new System.Drawing.Size(224, 139);
            this.rTxtBoxAddressBody.TabIndex = 1;
            this.rTxtBoxAddressBody.Text = "";
            // 
            // lblAddressBody
            // 
            this.lblAddressBody.AutoSize = true;
            this.lblAddressBody.Location = new System.Drawing.Point(3, 9);
            this.lblAddressBody.Name = "lblAddressBody";
            this.lblAddressBody.Size = new System.Drawing.Size(48, 13);
            this.lblAddressBody.TabIndex = 0;
            this.lblAddressBody.Text = "Address:";
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelCloseAddress);
            this.Controls.Add(this.btnUpdateCloseAddress);
            this.Name = "frmAddress";
            this.Text = "Address";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCloseAddress;
        private System.Windows.Forms.Button btnCancelCloseAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxAddressPostcode;
        private System.Windows.Forms.Label lblAddressPostcode;
        private System.Windows.Forms.TextBox txtBoxAddressCountry;
        private System.Windows.Forms.Label lblAddressCountry;
        private System.Windows.Forms.TextBox txtBoxAddressRegion;
        private System.Windows.Forms.Label lblAddressRegion;
        private System.Windows.Forms.TextBox txtBoxAddressCity;
        private System.Windows.Forms.Label lblAddressCity;
        private System.Windows.Forms.RichTextBox rTxtBoxAddressBody;
        private System.Windows.Forms.Label lblAddressBody;
    }
}