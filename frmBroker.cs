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
    public partial class frmBroker : Form
    {
        iBroker myBroker;

        //Hide default constructor
        private frmBroker()
        { }

        public frmBroker(bool isAgency)
        {
            InitializeComponent();

            myBroker = InstanceFactory.Broker();

            //Default to Agency for new brokers
            rButtonAgencyBroker.Checked = isAgency;
        }

        public frmBroker (iBroker myBrokerInstance)
        {
            InitializeComponent();

            myBroker = myBrokerInstance;

            txtBoxBrokerName.Text = myBroker.Name;
            txtBoxLandLinePhoneNo.Text = myBroker.LandLineTelNo;
            txtBoxWebSite.Text = myBroker.Website;
            if (myBroker.Address != null)
            {
                rTxtBoxBrokerAddress.Text = myBroker.Address.FullAddress;
            }

            FillAgencyList();

            FillContactList();

            //Sort out the indicator of the broker type
            if(myBroker.IsAgency == true)
            {
                rButtonAgencyBroker.Checked = true;
            }
            else
            {
                rButtonEmployerBroker.Checked = true;
            }

        }

        private void FillAgencyList()
        {
            var allBrokerNames = from m in myBroker.Brokers select new {m.BrokerID, m.Name };

            lstBoxAssociatedBrokers.DataSource = allBrokerNames.ToList();
            lstBoxAssociatedBrokers.ValueMember = "BrokerID";
            lstBoxAssociatedBrokers.DisplayMember = "Name";
            lstBoxAssociatedBrokers.SelectedIndex = -1;
        }

        private void FillContactList()
        {
            var allContactNames = from m in myBroker.Contacts select new { m.Name.FullName, m.ContactID };
            lstBoxBrokerContacts.DataSource = allContactNames.ToList();
            lstBoxBrokerContacts.ValueMember = "ContactID";
            lstBoxBrokerContacts.DisplayMember = "FullName";
            lstBoxBrokerContacts.SelectedIndex = -1;
        }

        private void btnAddBroker_Click(object sender, EventArgs e)
        {
            //Set up the list of brokers not associated to this broker
            FillUnassociatedBrokerList();
            
            //Show the list of brokers not associated to this broker
            pnlUnassociatedBrokers.Visible = true;


        }

        private void FillUnassociatedBrokerList()
        {
            var allUnassociatedBrokers = myBroker.GetAllUnassociatedBrokers();
            lstBoxUnassociatedBrokers.DataSource = allUnassociatedBrokers;
            lstBoxUnassociatedBrokers.ValueMember = "BrokerID";
            lstBoxUnassociatedBrokers.DisplayMember = "Name";
            lstBoxUnassociatedBrokers.SelectedIndex = -1;
        }

        private void btnAssociateBroker_Click(object sender, EventArgs e)
        {
            //Get the selected broker from the list
            Broker selectedBroker = (Broker)lstBoxUnassociatedBrokers.SelectedItem;

            //Add this broker to the list of brokers for this broker (make sense of that!)
            myBroker.Brokers.Add(selectedBroker);

            //Rebuild both lists
            FillAgencyList();
            FillUnassociatedBrokerList();
            
        }

        private void btnUpdateClose_Click(object sender, EventArgs e)
        {
            //First thing to do is check that a broker type has been selected.
            if(rButtonAgencyBroker.Checked == false && rButtonEmployerBroker.Checked == false)
            {
                MessageBox.Show("Select a broker type.", "No Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //Update the entity level attributes
            myBroker.IsAgency = rButtonAgencyBroker.Checked;
            myBroker.LandLineTelNo = txtBoxLandLinePhoneNo.Text;
            myBroker.Name = txtBoxBrokerName.Text;
            myBroker.Website = txtBoxWebSite.Text; 

            myBroker = myBroker.Save();

            CloseBrokerForm();
        }

        private void CloseBrokerForm()
        {
            this.Close();
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            frmAddress newAddressForm = new frmAddress();
            newAddressForm.ShowDialog();

            //If the user has cancelled out of the New Address form, we should not
            //set point to an empty address instance
            if (newAddressForm.myAddress.AddressID != 0)
            {
                //Now set the reference
                myBroker.Address = (Address)newAddressForm.myAddress;

                rTxtBoxBrokerAddress.Text = myBroker.Address.FullAddress;
            }

        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (myBroker.Address != null)
            {
                frmAddress newAddressForm = new frmAddress(myBroker.Address);
                newAddressForm.ShowDialog();

                myBroker.Address = (Address)newAddressForm.myAddress;

                rTxtBoxBrokerAddress.Text = myBroker.Address.FullAddress;
            }

        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            CloseBrokerForm();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            //Get the selected Contact from the listbox
            int thisContactID;
            if((lstBoxBrokerContacts.SelectedValue != null) && (int.TryParse(lstBoxBrokerContacts.SelectedValue.ToString(), out thisContactID)))
            {
                var newContact = myBroker.Contacts.Where(s => s.ContactID == thisContactID).FirstOrDefault<Contact>();

                frmContact newContactForm = new frmContact(newContact);

                newContactForm.ShowDialog();

                FillContactList();

            }            
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmContact newContactForm = new frmContact(myBroker.Address);

            newContactForm.ShowDialog();

            if (newContactForm.myContact.ContactID != 0)
            {
                myBroker.Contacts.Add((Contact)newContactForm.myContact);

                FillContactList();
            }
        }

        private void rButtonAgencyBroker_CheckedChanged(object sender, EventArgs e)
        {
            //We set the IsAgency value

            //We set the "Add Broker" button text and "Associated Brokers" label text as required
            if(rButtonAgencyBroker.Checked == true)
            {
                myBroker.IsAgency = true;
                btnAssociateBroker.Text = "Add Employer";
                btnAddBroker.Text = "Add Employer";
                lblAssociatedBrokers.Text = "Associated Employers";
            }
            else
            {
                myBroker.IsAgency = false;
                btnAssociateBroker.Text = "Add Agency";
                btnAddBroker.Text = "Add Agency";
                lblAssociatedBrokers.Text = "Associated Agencies";
            }
        }

        private void rButtonEmployerBroker_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
