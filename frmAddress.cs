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
    public partial class frmAddress : Form
    {
        public iAddress myAddress;

        public frmAddress()
        {
            InitializeComponent();

            myAddress = InstanceFactory.Address();

        }

        public frmAddress(iAddress myAddressInstance)
        {
            InitializeComponent();

            myAddress = myAddressInstance;
            rTxtBoxAddressBody.Text = myAddress.BodyText;
            txtBoxAddressCity.Text = myAddress.City;
            txtBoxAddressRegion.Text = myAddress.Region;
            txtBoxAddressCountry.Text = myAddress.Country;
            txtBoxAddressPostcode.Text = myAddress.Postcode;
        }

        private void btnUpdateCloseAddress_Click(object sender, EventArgs e)
        {
            //Update the values
            myAddress.BodyText = rTxtBoxAddressBody.Text;
            myAddress.City = txtBoxAddressCity.Text;
            myAddress.Region = txtBoxAddressRegion.Text;
            myAddress.Country = txtBoxAddressCountry.Text;
            myAddress.Postcode = txtBoxAddressPostcode.Text;

            //Save the address
            myAddress = myAddress.Save();

            CloseAddressForm();            
        }

        private void CloseAddressForm()
        {
            this.Close();
        }

        private void btnCancelCloseAddress_Click(object sender, EventArgs e)
        {
            CloseAddressForm();
        }
    }
}
