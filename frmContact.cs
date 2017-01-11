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
    public partial class frmContact : Form
    {

        public iContact myContact;

        private frmContact()
        {

        }

        public frmContact(iAddress parentAddress)
        {
            InitializeComponent();

            myContact = InstanceFactory.Contact();

            myContact.Address = (Address)parentAddress;

            rTextBoxContactAddress.Text = myContact.Address.FullAddress;

        }

        public frmContact(iContact myContactInstance)
        {

            InitializeComponent();

            myContact = myContactInstance;

            //Fill in the values
            txtBoxName.Text = myContact.Name.FullName;
            txtBoxContactPosition.Text = myContact.Position;
            txtBoxContactEmail.Text = myContact.Email;
            txtBoxContactLandLineNo.Text = myContact.LandLineTelNo;
            txtBoxContactMobileNo.Text = myContact.MobileTelNo;
            rTextBoxContactAddress.Text = myContact.Address.FullAddress;

        }

        private void CloseContactForm()
        {
            this.Close();
        }

        private void btnUpdateCloseAddress_Click(object sender, EventArgs e)
        {
            //Stuff for saving the Contact
            myContact.Position = txtBoxContactPosition.Text;
            myContact.Email = txtBoxContactEmail.Text;
            myContact.LandLineTelNo = txtBoxContactLandLineNo.Text;
            myContact.MobileTelNo = txtBoxContactMobileNo.Text;
            myContact.Save();

            CloseContactForm();
        }

        private void btnCancelCloseAddress_Click(object sender, EventArgs e)
        {
            CloseContactForm();
        }

        private void btnEditContactName_Click(object sender, EventArgs e)
        {
            frmName newNameForm = new frmName(myContact.Name);
            newNameForm.ShowDialog();

            myContact.Name = (Name)newNameForm.myName;
            txtBoxName.Text = myContact.Name.FullName;
        }

        private void btnNewContactName_Click(object sender, EventArgs e)
        {
            frmName newNameForm = new frmName();
            newNameForm.ShowDialog();

            if (newNameForm.myName.NameID != 0)
            {
                myContact.Name = (Name)newNameForm.myName;
                txtBoxName.Text = myContact.Name.FullName;
            }
        }

        private void btnNewContactAddress_Click(object sender, EventArgs e)
        {
            frmAddress newAddressForm = new frmAddress();
            newAddressForm.ShowDialog();

            //If the user has cancelled out of the New Address form, we should not
            //set point to an empty address instance
            if (newAddressForm.myAddress.AddressID != 0)
            {
                //Now set the reference
                myContact.Address = (Address)newAddressForm.myAddress;

                rTextBoxContactAddress.Text = myContact.Address.FullAddress;
            }
        }

        private void btnEditContactAddress_Click(object sender, EventArgs e)
        {
            frmAddress newAddressForm = new frmAddress(myContact.Address);
            newAddressForm.ShowDialog();

            myContact.Address = (Address)newAddressForm.myAddress;

            rTextBoxContactAddress.Text = myContact.Address.FullAddress;
        }
    }
}
