using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class frmName : Form
    {

        public iName myName;

        public frmName()
        {
            InitializeComponent();

            myName = InstanceFactory.Name();
        }

        public frmName(iName myNameInstance)
        {
            InitializeComponent();

            myName = myNameInstance;

            cboBoxNameTitles.Text = myName.Title;
            txtBoxNameFirstName.Text = myName.FirstName;
            txtBoxNameMiddleName.Text = myName.MiddleName;
            txtBoxNameSurname.Text = myName.Surname;
        }

        private void CloseNameForm()
        {
            this.Close();
        }

        private void btnCancelCloseName_Click(object sender, EventArgs e)
        {
            CloseNameForm();
        }

        private void btnUpdateCloseName_Click(object sender, EventArgs e)
        {
            //Update the instance
            myName.Title = cboBoxNameTitles.Text;
            myName.FirstName = txtBoxNameFirstName.Text;
            myName.MiddleName = txtBoxNameMiddleName.Text;
            myName.Surname = txtBoxNameSurname.Text;

            //Save/Update the Name instance.
            myName = myName.Save();

            CloseNameForm();
        }
    }
}
