using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class frmJobLead : Form
    {
        iJobLead myJobLead;

        public frmJobLead()
        {
            InitializeComponent();
            
            //Forms should have no control over what concrete class is used.
            //We have a "factory" that handles this.
            myJobLead = InstanceFactory.JobLead();
  
            //Job status drop down list and current value
            cboJobStatusList.DataSource = myJobLead.StatusList;

            InitialiseBrokerDropdown(cboAgencyNames, true);
            InitialiseBrokerDropdown(cboEmployerNames, false);

            SetNotesCount();
        }

        private void btnCloseJobLead_Click(object sender, EventArgs e)
        {
            //Update the joblead with the current selected values

            //Prepare the local JobLead instance to be saved.
            myJobLead.Status = cboJobStatusList.Text;
            myJobLead.JobTitle = txtBoxJobTitle.Text;
            myJobLead.Source = txtBoxLeadSource.Text;
            myJobLead.CVOrApplicationLocation = txtBoxApplicationDocLocation.Text;
            myJobLead.CoverLetterLocation = txtBoxCoverLetterLocation.Text;
            myJobLead.Ref_One = txtBoxRefOne.Text;
            myJobLead.Ref_Two = txtBoxRefTwo.Text;
            myJobLead.Ref_Three = txtBoxRefThree.Text;

            //Now we need to sort out the child entity values.
            int thisContactID;

            if ((cboAgencyContactNames.SelectedValue != null) && (int.TryParse(cboAgencyContactNames.SelectedValue.ToString(), out thisContactID)))
            {
                myJobLead.AgencyContactID = thisContactID;
            }

            if ((cboEmployerContactNames.SelectedValue != null) && (int.TryParse(cboEmployerContactNames.SelectedValue.ToString(), out thisContactID)))
            {
                myJobLead.EmployerContactID = thisContactID;
            }

            int thisBrokerID;

            if((cboAgencyNames.SelectedValue != null)&&(int.TryParse(cboAgencyNames.SelectedValue.ToString(), out thisBrokerID)))
            {
                myJobLead.AgencyBrokerID = thisBrokerID;
            }

            if ((cboEmployerNames.SelectedValue != null) && (int.TryParse(cboEmployerNames.SelectedValue.ToString(), out thisBrokerID)))
            {
                myJobLead.EmployerBrokerID = thisBrokerID;
            }

            //Call the Save() method for this JobLead instance
            myJobLead.Save();

            //Close the form
            CloseJobLeadForm();

        }

        private void CloseJobLeadForm()
        {
            this.Close();
        }

        //We have an existing job lead instance to populate this form with
        public frmJobLead(iJobLead myJobInstance)
        {
            InitializeComponent();

            myJobLead = myJobInstance;

            //Creation date
            dateTimeCreationDateTime.Value = myJobLead.Date;

            //Job status drop down list and current value
            cboJobStatusList.DataSource = myJobLead.StatusList;
            //Set the status value in the drop down list to the value the JobLead instance has (if this is a new job lead, this will be null)
            cboJobStatusList.SelectedItem = myJobLead.Status != null ? myJobLead.Status : cboJobStatusList.Items[0].ToString();

            //An existing job may have an entry for agency and employer, or it may not (but at least one should be present).
            //If one is present, and the other is blank, we should initialise the blank one with the list of agencies/employers
            //the other deals with. If both are blank, we get all the agencies and employers for all the Broker instancies.

            //Check if we have an Agency Broker
            if (myJobLead.AgencyBroker == null)
            {
                //Do we have an Employer Broker
                if(myJobLead.EmployerBroker == null)
                {
                    //Initialise the Agency list with all the agencies
                    InitialiseBrokerDropdown(cboAgencyNames, true);
                }
                else
                {
                    //Initialise the Agency list with the agencies that work with this employer
                    //NOTE: THE SelectedValue_Changed EVENT WILL BE DOING THE SAME THING
                    InitialiseBrokerDropdown(cboAgencyNames, myJobLead.EmployerBroker);
                }
            }
            else
            {
                //Populate the Agency list with just one entry
                InitialiseBrokerDropdown(cboAgencyNames, myJobLead.AgencyBrokerID, myJobLead.AgencyBroker.Name);                

                //Populate the Agency Contact list with all the contacts for this agent
                InitialiseContactDropDown(cboAgencyContactNames, myJobLead.AgencyBroker);

                //If we have an agency contact set, make that the selected item in the list
                if (myJobLead.AgencyContact != null)
                {
                    cboAgencyContactNames.SelectedValue = myJobLead.AgencyContactID;
                }
                
            }

            //Now do the same for an Employer Broker
            if(myJobLead.EmployerBroker == null)
            {
                //Do we have an Agency Broker
                if(myJobLead.AgencyBroker == null)
                {
                    //Initialise the Employer list with all employers
                    InitialiseBrokerDropdown(cboEmployerNames, false);
                }
                else
                {
                    //Initialise the Employer list with the employers that work with this agency
                    //NOTE: THE SelectedValue_Changed EVENT WILL BE DOING THE SAME THING
                    InitialiseBrokerDropdown(cboEmployerNames, myJobLead.AgencyBroker);
                }
            }
            else
            {
                //Populate the Employer list with just one entry
                InitialiseBrokerDropdown(cboEmployerNames, myJobLead.EmployerBrokerID, myJobLead.EmployerBroker.Name);

                //Populate the Employer Contact list with all the contacts for this agent
                InitialiseContactDropDown(cboEmployerContactNames, myJobLead.EmployerBroker);

                //If we have an employer contact set, make that the selected item in the list
                if (myJobLead.EmployerContact != null)
                {
                    cboEmployerContactNames.SelectedValue = myJobLead.EmployerContactID;
                }
            }
            
            //Now we just simply fill in the text values for the rest of the Job Lead.
            txtBoxJobTitle.Text = myJobLead.JobTitle;
            txtBoxLeadSource.Text = myJobLead.Source;
            txtBoxApplicationDocLocation.Text = myJobLead.CVOrApplicationLocation;
            txtBoxCoverLetterLocation.Text = myJobLead.CoverLetterLocation;
            txtBoxRefOne.Text = myJobLead.Ref_One;
            txtBoxRefTwo.Text = myJobLead.Ref_Two;
            txtBoxRefThree.Text = myJobLead.Ref_Three;
            SetNotesCount();

            

        }

        /// <summary>
        /// This should not be called
        /// </summary>
        /// <param name="thisComboBox"></param>
        private void InitialiseBrokerDropDown(ComboBox thisComboBox)
        {
            var allBrokerNames = from m in myJobLead.AgencyBroker.Brokers select new { m.BrokerID, m.Name };
            thisComboBox.DataSource = allBrokerNames.ToList();
            thisComboBox.ValueMember = "BrokerID";
            thisComboBox.DisplayMember = "Name";
            thisComboBox.SelectedIndex = -1;
        }

        private void InitialiseBrokerDropdown(ComboBox thisComboBox, Broker thisBroker)
        {
            var allBrokerNames = from m in thisBroker.Brokers select new { m.BrokerID, m.Name };
            thisComboBox.DataSource = allBrokerNames.ToList();
            thisComboBox.ValueMember = "BrokerID";
            thisComboBox.DisplayMember = "Name";
            thisComboBox.SelectedIndex = -1;
        }

        
        private void InitialiseBrokerDropdown(ComboBox thisComboBox, bool isAgency)
        {
            thisComboBox.DataSource = myJobLead.GetAllBrokers(isAgency);
            thisComboBox.ValueMember = "BrokerID";
            thisComboBox.DisplayMember = "Name";
            thisComboBox.SelectedIndex = -1;
        }

        private void InitialiseBrokerDropdown(ComboBox thisComboBox, int? thisKey, string thisValue)
        {
            Dictionary<int?, string> agencyList = new Dictionary<int?, string>();
            agencyList.Add(thisKey, thisValue);
            thisComboBox.DataSource = agencyList.ToList();
            thisComboBox.ValueMember = "Key";
            thisComboBox.DisplayMember = "Value";
            //We don't set the .SelectedIndex = -1 as there is only one item in the list, and that should be displayed as default.
        }

        private void InitialiseContactDropDown(ComboBox thisComboBox, iBroker thisBroker)
        {
            var allContactNames = from m in thisBroker.Contacts select new { m.Name.FullName, m.ContactID };
            thisComboBox.DataSource = allContactNames.ToList();
            thisComboBox.ValueMember = "ContactID";
            thisComboBox.DisplayMember = "FullName";
            thisComboBox.SelectedIndex = -1;
        }   

        private void cboAgencyNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //First, we need to check we can convert the value member to an Int
            int thisBrokerID;

            //Is the selected value NULL, or not convertable to an int, or is this a one item list (an existing job lead)?
            //If "Yes", we don't need to do anything further.            
            if ((cboAgencyNames.SelectedValue == null) || (!int.TryParse(cboAgencyNames.SelectedValue.ToString(), out thisBrokerID)))

            {
                return;
            }

            //Get a copy of this agency broker object
            Broker newBroker = myJobLead.GetBroker(thisBrokerID);

            int currentEmployerBrokerID;
            if((cboEmployerNames.SelectedValue == null) || (!int.TryParse(cboEmployerNames.SelectedValue.ToString(), out currentEmployerBrokerID)))
            {
                currentEmployerBrokerID = -1;
            }            

            //Replace the existing AgencyBroker
            myJobLead.AgencyBroker = newBroker;

            //Repopulate the AgencyContacts drop down
            InitialiseContactDropDown(cboAgencyContactNames, myJobLead.AgencyBroker);

            //Clear the current Agency Contact name
            myJobLead.AgencyContact = null;

            //We need to guard against resetting the Employer list if it has a value
            InitialiseBrokerDropdown(cboEmployerNames, myJobLead.AgencyBroker);
            cboEmployerNames.SelectedValue = currentEmployerBrokerID;
            
        }

        private void cboEmployerNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //First, we need to check we can convert the value member to an Int
            int thisBrokerID;

            //Is the selected value NULL, or not convertable to an int, or is this a one item list (an existing job lead)?
            //If "Yes", we don't need to do anything further.            
            if ((cboEmployerNames.SelectedValue == null) || (!int.TryParse(cboEmployerNames.SelectedValue.ToString(), out thisBrokerID)))
            {
                return;
            }

            //Get a copy of this agency broker object
            //JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            //Broker newBroker = thisJobLeadRepo.GetBroker(thisBrokerID);
            Broker newBroker = myJobLead.GetBroker(thisBrokerID);

            int currentAgencyBrokerID;
            if ((cboAgencyNames.SelectedValue == null) || (!int.TryParse(cboAgencyNames.SelectedValue.ToString(), out currentAgencyBrokerID)))
            {
                currentAgencyBrokerID = -1;
            }

            //Replace the existing AgencyBroker
            myJobLead.EmployerBroker = newBroker;

            //Repopulate the AgencyContacts drop down
            InitialiseContactDropDown(cboEmployerContactNames, myJobLead.EmployerBroker);

            //Clear the current Agency Contact name
            myJobLead.EmployerContact = null;

            //We need to guard against resetting the Agency list if it has a value
            InitialiseBrokerDropdown(cboAgencyNames, myJobLead.EmployerBroker);
            cboAgencyNames.SelectedValue = currentAgencyBrokerID;

        }

        private void btnShowAgency_Click(object sender, EventArgs e)
        {
            //frmBroker newBrokerForm = new frmBroker(myJobLead.AgencyBroker);
            //newBrokerForm.ShowDialog();
            ShowExistingBrokerForm(myJobLead.AgencyBroker);
        }

        private void btnNewAgencyBroker_Click(object sender, EventArgs e)
        {

            ShowNewBrokerForm(true);

            //Refresh the agency drop down list
            InitialiseBrokerDropdown(cboAgencyNames, true);
        }

        private void btnShowEmployer_Click(object sender, EventArgs e)
        {

            ShowExistingBrokerForm(myJobLead.EmployerBroker);
        }

        private void btnNewEmployerBroker_Click(object sender, EventArgs e)
        {
            ShowNewBrokerForm(false);

            InitialiseBrokerDropdown(cboEmployerNames, false);

        }

        private void ShowExistingBrokerForm(iBroker selectedBroker)
        {
            frmBroker newBrokerForm = new frmBroker(selectedBroker);
            newBrokerForm.ShowDialog();
        }

        private void ShowNewBrokerForm(bool isAgency)
        {
            frmBroker newBrokerForm = new frmBroker(isAgency);
            newBrokerForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseJobLeadForm();
        }

        private void btnShowAgencyContact_Click(object sender, EventArgs e)
        {
            //Guard against passing a NULL object
            if (myJobLead.AgencyContact != null)
            {
                //Use the Agency Contact 
                frmContact newContactForm = new frmContact(myJobLead.AgencyContact);
                newContactForm.ShowDialog();
            }

        }

        private void btnShowEmployerContact_Click(object sender, EventArgs e)
        {
            //Guard against passing a NULL object
            if (myJobLead.EmployerContact != null)
            {
                //Use the Employer Contact
                frmContact newContactForm = new frmContact(myJobLead.EmployerContact);
                newContactForm.ShowDialog();
            }

        }

        private void cboAgencyContactNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //First, we need to check we can convert the value member to an Int
            int thisContactID;

            //Is the selected value NULL, or not convertable to an int, or is this a one item list (an existing job lead)?
            //If "Yes", we don't need to do anything further.            
            if ((cboAgencyContactNames.SelectedValue == null) || (!int.TryParse(cboAgencyContactNames.SelectedValue.ToString(), out thisContactID)))

            {
                return;
            }

            //Get a copy of this Contact object
            Contact newContact = myJobLead.GetContact(thisContactID);

            //Replace the existing AgencyBroker
            myJobLead.AgencyContact = newContact;
        }

        private void cboEmployerContactNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //First, we need to check we can convert the value member to an Int
            int thisContactID;

            //Is the selected value NULL, or not convertable to an int, or is this a one item list (an existing job lead)?
            //If "Yes", we don't need to do anything further.            
            if ((cboEmployerContactNames.SelectedValue == null) || (!int.TryParse(cboEmployerContactNames.SelectedValue.ToString(), out thisContactID)))

            {
                return;
            }

            //Get a copy of this Contact object
            Contact newContact = myJobLead.GetContact(thisContactID);

            //Replace the existing AgencyBroker
            myJobLead.EmployerContact = newContact;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            //Create a new nore form
            frmNote newNoteForm = new frmNote(myJobLead.JobLeadNotes);

            //Show the note form in a dialog
            newNoteForm.ShowDialog();

            //Get back the new note
            Note newJobNote = (Note)newNoteForm.myNote;

            //If they saved the note, add it to the List<Note> for this job lead.
            if (newJobNote.NoteID != 0)
            {
                myJobLead.JobLeadNotes.Add(newJobNote);
            }

            SetNotesCount();
        }

        private void SetNotesCount()
        {
            int notesCount = myJobLead.JobLeadNotes.Count;
            lblNotesCount.Text = "Job Notes - " + notesCount;
        }

        /// <summary>
        /// Launch the window to attach a screen grab (most pobably a web page)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPasteFrmClipboard_Click(object sender, EventArgs e)
        {

            //Declare the ScreenGrab form we will launch
            frmScreenGrab screenGrabForm;

            //Depending on if we alreday have a screen grab for this job lead, use the
            //appropriate from constructor
            if(myJobLead.JobLeadImage == null)
            {
                screenGrabForm = new frmScreenGrab();
            }
            else
            {
                screenGrabForm = new frmScreenGrab(myJobLead.JobLeadImage);
            }

            //Show the form
            screenGrabForm.ShowDialog();

            //If a screen grab has been taken, set the value in this JobLead instance.
            if(screenGrabForm.ScreenGrab != null)
            {
                myJobLead.JobLeadImage = screenGrabForm.ScreenGrab;
            }

        }
    }
}
