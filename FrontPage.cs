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
    public partial class frmFrontPage : Form
    {

        //This value stores the current search type.
        //This means each time we do a search, we do not
        //need to find out which search type we are doing.
        //The radio button click events will have the responsibility
        //for changing this value
        private string searchType; //This could/should be an enumerated type.

        public frmFrontPage()
        {
            InitializeComponent();

            InitialiseStatusList();

            ReloadJobLeadGrid();
            ReloadAgencyBrokerGrid();

            //Find a better way of doing this....
            rBtnJobTitle.Checked = true;
            rBtnJobTitle_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitialiseStatusList()
        {
            var items = chkListBoxStatus.Items;
            items.Add("Unset");
            items.Add("CV Sent");
            items.Add("Application Form Requested");
            items.Add("Application Form Sent");
            items.Add("Application Acknowledged");
            items.Add("Pending");
            items.Add("Interview Arranged");
            items.Add("Closed");
        }

        private void btnDoSomething_Click(object sender, EventArgs e)
        {
            #region OldTestDataGeneration
            //using (var ctx = new JobLeadContext())
            //{
            //    ///*
            //    Name2 newName = new Name2();
            //    newName.FirstName = "James";
            //    newName.MiddleName = "Mark";
            //    newName.Surname = "McDonald";
            //    newName.Title = "Dr";

            //    //ctx.Names.Add(newName);

            //    Address2 newAddress = new Address2();
            //    newAddress.BodyText = "Suite 5,\n2 Constitution Street,\nLeith";
            //    newAddress.City = "Edinburgh";
            //    newAddress.Region = "East Lothian";
            //    newAddress.Country = "Scotland";
            //    newAddress.Postcode = "EH6 6JA";

            //    //ctx.Addresses.Add(newAddress);

            //    Contact2 newContact = new Contact2();
            //    newContact.Address = newAddress;
            //    newContact.Name = newName;
            //    newContact.Email = "me@here.com";
            //    newContact.Position = "Worker";
            //    newContact.LandLineTelNo = "0131 444 7642";
            //    newContact.MobileTelNo = "0773355667";

            //    Broker2 newBroker = new Broker2();
            //    //newBroker.myContact = newContact;
            //    newBroker.Contacts.Add(newContact);
            //    newBroker.Name = "New Broker Name";

            //    Address2 newAddress2 = new Address2();
            //    newAddress2.BodyText = "4 Kittle Yards,\n2 Causewayside,\nNewington";
            //    newAddress2.City = "Edinburgh";
            //    newAddress2.Region = "East Lothian";
            //    newAddress2.Country = "Scotland";
            //    newAddress2.Postcode = "EH9 1PJ";

            //    newBroker.Address = newAddress2;
            //    newBroker.LandLineTelNo = "0131 668 8010";
            //    newBroker.Website = "WWW.NewBroker.CO.UK";
            //    newBroker.IsAgency = true;

            //    //Test adding a broker to a broker.
            //    Broker2 newBroker2 = new Broker2();
            //    newBroker2.Name = "Broker's Broker1";
            //    newBroker.Brokers.Add(newBroker2);

            //    Broker2 newBroker3 = new Broker2();
            //    newBroker3.Name = "Broker's Broker2";
            //    newBroker.Brokers.Add(newBroker3);

            //    JobLead2 newJobLead = new JobLead2();
            //    newJobLead.AgencyBroker = newBroker;
            //    newJobLead.AgencyContact = newContact;
            //    newJobLead.CoverLetterLocation = @"C:\CoverLetterDir\CoverLetter.doc";
            //    newJobLead.CVOrApplicationLocation = @"C:\CVLocationDir\cv.doc";
            //    newJobLead.Date = DateTime.Now;
            //    newJobLead.Ref_One = "WID001/0034";
            //    newJobLead.Ref_Two = "AgID-23-12345/002";
            //    newJobLead.Source = @"http://www.bbc.co.uk/news";
            //    newJobLead.Status = newJobLead.StatusList[2];

            //    Broker2 newEmployerBroker = new Broker2();
            //    newEmployerBroker.Name = "Employer Broker";
            //    newEmployerBroker.Address = newAddress;
            //    newEmployerBroker.IsAgency = false;

            //    newJobLead.EmployerBroker = newEmployerBroker;

            //    Name2 newName2 = new Name2();
            //    newName2.FirstName = "Edward";
            //    newName2.MiddleName = "Paul";
            //    newName2.Surname = "Innes";
            //    newName2.Title = "Mr";

            //    Contact2 newContact2 = new Contact2();
            //    newContact2.Address = newAddress2;
            //    newContact2.Name = newName2;
            //    newContact2.Email = "him@there.co.uk";
            //    newContact2.Position = "Advisor";
            //    newContact2.LandLineTelNo = "0131 222 6238";
            //    newContact2.MobileTelNo = "07766114488";

            //    newJobLead.EmployerContact = newContact2;


            //    //ctx.Names.Add(newName);
            //    //ctx.Addresses.Add(newAddress);
            //    //ctx.Contacts.Add(newContact);
            //    //ctx.Brokers.Add(newBroker);
            //    ctx.JobLeads.Add(newJobLead);


            //    ctx.SaveChanges();
            //    //*/

            //}            
            #endregion

            #region NewTestDataGeneration
            //12 Names
            Name name_01 = new Name("Mr", "Andrew", "John", "McDonald");
            Name name_02 = new Name("Professor", "William", "Henry", "Maitland");
            Name name_03 = new Name("Miss", "Fiona", "Shirley", "Edwards");
            Name name_04 = new Name("Mr", "Brian", "Ian", "Jones");
            Name name_05 = new Name("Dr", "Mary", "Edith", "Fforbes");
            Name name_06 = new Name("Miss", "July", "Margret", "Denby");
            Name name_07 = new Name("Mr", "Oliver", "Peter", "Henrikson");
            Name name_08 = new Name("Ms", "Audrey", "Louise", "Monks");
            Name name_09 = new Name("Mr", "Malcolm", "Frank", "Noble");
            Name name_10 = new Name("Miss", "Edith", "Veronica", "Simons");
            Name name_11 = new Name("Dr", "James", "Scott");
            Name name_12 = new Name("Professor", "Kate", "Leslie", "Brown");


            //8 Addresses
            Address address_01 = new Address("38/2 Prince Regent Street,\nLeith", "Edinburgh", "Lothian", "UK", "EH6 4AT");
            Address address_02 = new Address("Suite 5,\n2Commercial Street,\nLeith", "Edinburgh", "Lothan", "Scotland", "EH6 6JA");
            Address address_03 = new Address("4 Kittle Yards,\nCausewayside,\nNewington", "Edinburgh", "Lothian", "Britain", "EH9 1PJ");
            Address address_04 = new Address("23/23a Dalmeny Street", "Edinburgh", "East Lothian", "UK", "EH6 8PJ");
            Address address_05 = new Address("113 West Regent Street", "Glasgow", "Strathclyde", "Scotland", "G2 2RU");
            Address address_06 = new Address("7 Castle Street", "Edinburgh", "Lothian", "UK", "EH2 3AP");
            Address address_07 = new Address("9 Colme Street", "Edinburgh", "West Lothian", "Britain", "EH3 6AA");
            Address address_08 = new Address("17A South Gyle Crescent", "Edinburgh", "Scotland", "Mid Lothian", "EH12 9FL");

            //12 Contacts
            Contact contact_01 = new Contact(name_01, address_01, "Associate", "A.J.McDonald@there.com", "077739614", "0131 652 7359");
            Contact contact_02 = new Contact(name_02, address_02, "Department Head", "WilliamHMaitland@edin.ac,uk", "", "0131 391 2519");
            Contact contact_03 = new Contact(name_03, address_03, "Recruiter", "EdwardsFS@ouside.co.uk", "077183962", "0131 724 2975");
            Contact contact_04 = new Contact(name_04, address_04, "Manager", "BIJ@where.com", "077163615", "0131 272 4725");
            Contact contact_05 = new Contact(name_05, address_05, "Development Director", "M.Fforbes@wherever.co.uk", "077253951", "0141 263 2748");
            Contact contact_06 = new Contact(name_06, address_06, "HR Director", "Denby.July@elsewhere.com", "077451835", "0131 263 1462");
            Contact contact_07 = new Contact(name_07, address_07, "Placement Officer", "Oliver.Henrikson@newplace.co.uk", "", "");
            Contact contact_08 = new Contact(name_08, address_08, "Consultant", "AudreyMonks@whoknows.co.uk", "077253194", "");
            Contact contact_09 = new Contact(name_09, address_04, "Lead Recruiter", "MFN@where.com", "077451736", "0131 272 4720");
            Contact contact_10 = new Contact(name_10, address_07);
            Contact contact_11 = new Contact(name_11, address_04, ".NET Recruiter", "JLS@where.com", "077369643", "0131 272 4722");
            Contact contact_12 = new Contact(name_12, address_05, "Team Leader", "K.Brown@wherever.co.uk", "077254951", "0141 263 2724");

            //2 Employer Brokers
            Broker employerBroker_01 = new Broker();
            employerBroker_01.IsAgency = false;
            employerBroker_01.Name = "Bleeding Edge Development.";
            employerBroker_01.Address = address_02;
            employerBroker_01.LandLineTelNo = "0131 391 2500";
            employerBroker_01.Website = @"www.NewOps.co.uk";
            employerBroker_01.Contacts.Add(contact_02); 

            Broker employerBroker_02 = new Broker();
            employerBroker_02.IsAgency = false;
            employerBroker_02.Name = "Blue Sky Solutions.";
            employerBroker_02.Address = address_05;
            employerBroker_02.LandLineTelNo = "0141 263 2700";
            employerBroker_02.Website = @"www.BlueSkySolutions.com";
            employerBroker_02.Contacts.Add(contact_05);
            employerBroker_02.Contacts.Add(contact_12);

            //4 Agency Brokers
            Broker agencyBroker_01 = new Broker();
            agencyBroker_01.IsAgency = true;
            agencyBroker_01.Name = "New Doors.";
            agencyBroker_01.Address = address_01;
            agencyBroker_01.LandLineTelNo = "0131 652 7300";
            agencyBroker_01.Website = @"www.NewDoorsLtd.co.uk";
            agencyBroker_01.Contacts.Add(contact_01);

            Broker agencyBroker_02 = new Broker();
            agencyBroker_02.IsAgency = true;
            agencyBroker_02.Name = "First Chance.";
            agencyBroker_02.Address = address_03;
            agencyBroker_02.LandLineTelNo = "0131 724 2900";
            agencyBroker_02.Website = @"www.FirstChance.co.uk";
            agencyBroker_02.Contacts.Add(contact_03);

            Broker agencyBroker_03 = new Broker();
            agencyBroker_03.IsAgency = true;
            agencyBroker_03.Name = "Finnly & Associates.";
            agencyBroker_03.Address = address_04;
            agencyBroker_03.LandLineTelNo = "0131 272 4700";
            agencyBroker_03.Website = @"www.FinnlyAndAssociates.com";
            agencyBroker_03.Contacts.Add(contact_04);
            agencyBroker_03.Contacts.Add(contact_09);
            agencyBroker_03.Contacts.Add(contact_11);

            Broker agencyBroker_04 = new Broker();
            agencyBroker_04.IsAgency = true;
            agencyBroker_04.Name = "IT Solutions Limited.";
            agencyBroker_04.Address = address_06;
            agencyBroker_04.LandLineTelNo = "0131 263 1462";
            agencyBroker_04.Website = @"www.ITSolutionsLtd.co.uk";
            agencyBroker_04.Contacts.Add(contact_06);

            //As we are connecting brokers to brokers, we could not join them until after they have all been created.
            employerBroker_01.Brokers.Add(agencyBroker_01);
            employerBroker_01.Brokers.Add(agencyBroker_03);

            employerBroker_02.Brokers.Add(agencyBroker_02);
            employerBroker_02.Brokers.Add(agencyBroker_03);
            employerBroker_02.Brokers.Add(agencyBroker_04);

            agencyBroker_01.Brokers.Add(employerBroker_01);

            agencyBroker_02.Brokers.Add(employerBroker_02);

            agencyBroker_03.Brokers.Add(employerBroker_01);
            agencyBroker_03.Brokers.Add(employerBroker_02);

            agencyBroker_04.Brokers.Add(employerBroker_02);

            //2 Job Leads
            JobLead jobLead_01 = new JobLead();
            jobLead_01.JobTitle = ".NET Software Engineer";
            jobLead_01.AgencyBroker = agencyBroker_01;
            jobLead_01.AgencyContact = contact_01;
            jobLead_01.EmployerBroker = employerBroker_01;
            jobLead_01.EmployerContact = contact_02;
            jobLead_01.CoverLetterLocation = @"C:\Jobs\Applications\JobLeadOneCover.doc";
            jobLead_01.CVOrApplicationLocation = @"C:\Jobs\CV\CV.Doc";
            jobLead_01.Ref_One = @"Job01\0023";
            jobLead_01.Ref_Two = @"ABC-xyz-123";
            jobLead_01.Ref_Three = @"JobOne Ref 3";
            jobLead_01.Source = @"www.JobsNow.co.uk\002345\abc.aspx";
            jobLead_01.Status = jobLead_01.StatusList[2];

            JobLead jobLead_02 = new JobLead();
            jobLead_02.JobTitle = "C# Developer";
            jobLead_02.AgencyBroker = agencyBroker_03;
            jobLead_02.AgencyContact = contact_09;
            jobLead_02.EmployerBroker = employerBroker_02;
            jobLead_02.EmployerContact = contact_05;
            jobLead_02.CoverLetterLocation = @"C:\Jobs\Applications\JobLeadTwoCover.doc";
            jobLead_02.CVOrApplicationLocation = @"C:\Jobs\Applications\JobLeadTwoApplication.doc";
            jobLead_02.Ref_One = @"Job Two Ref One";
            jobLead_02.Ref_Two = @"JKL\004\TRW\09-34";
            jobLead_02.Ref_Three = @"Job34-0034";
            jobLead_02.Source = @"www.jobFinder.com\flax0034\job23.aspx";
            jobLead_02.Status = jobLead_01.StatusList[4];

            using (var ctx = new JobLeadContext())
            {
                ctx.JobLeads.Add(jobLead_01);
                ctx.JobLeads.Add(jobLead_02);

                ctx.SaveChanges();
            }

            /*
            JobLead currentJobLead;

            using (var ctx = new JobLeadContext())
            {
                currentJobLead = ctx.JobLeads.Include("AgencyContact").Where(s => s.JobLeadID == 1).FirstOrDefault<JobLead>();
            }

            if (currentJobLead != null)
            {
                currentJobLead.JobTitle = "Changed Title";
                currentJobLead.AgencyContact = contact_11;
            }

            using (var ctx = new JobLeadContext())
            {
                ctx.Entry(currentJobLead).State = System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();
            }
            */


            #endregion

        }

        private void btnGetJobLeads_Click(object sender, EventArgs e)
        {

            ReloadJobLeadGrid();

            ReloadAgencyBrokerGrid();


        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //A row has been double clicked. We need to get the JobLeadID value, extract the JobLead instance
            //and then pass this to the form to display the job lead.
            int jobLeadIDSelected = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["JobLeadID"].Value.ToString());            

            //PUT THIS IN A Using BLOCK?
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            iJobLead jobLeadSelected = thisJobLeadRepo.GetJobLead(jobLeadIDSelected);

            frmJobLead newJobLeadForm = new frmJobLead(jobLeadSelected);
            newJobLeadForm.ShowDialog();

            //Now reinitialise the Job Lead Grid
            ReloadJobLeadGrid();
        }

        //Create a new (blank) job lead
        private void btnNewJobLead_Click(object sender, EventArgs e)
        {
            frmJobLead newJobLeadForm = new frmJobLead();
            newJobLeadForm.ShowDialog();

            //Now reinitialise the Job Lead Grid
            ReloadJobLeadGrid();

        }        

        private void ReloadJobLeadGrid()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            dataGridView.DataSource = thisJobLeadRepo.GetJobLeadGridDatasource();
            dataGridView.Columns["JobLeadID"].Visible = false;
        }

        private void ReloadAgencyBrokerGrid()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            dataGridAgencies.DataSource = thisJobLeadRepo.GetAgencyBrokersDatasource();
            dataGridAgencies.Columns["BrokerID"].Visible = false;
            
        }

        private void btnNewBroker_Click(object sender, EventArgs e)
        {
            //We will default to showing an Agency broker for new brokers.
            frmBroker newBrokerForm = new frmBroker(true);
            newBrokerForm.ShowDialog();
        }

        private void btnSearchJobLeads_Click(object sender, EventArgs e)
        {
            //We (currently) have four different search facilities.
            //Job Title
            //Date Range
            //Status
            //Reference value

            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();


            switch (searchType)
            {
                case "JobType":
                    dataGridView.DataSource = thisJobLeadRepo.GetJobTitleFilteredJobLeadGridDataSource(txtBoxSearchText.Text);
                    break;

                case "DateType":
                    dataGridView.DataSource = thisJobLeadRepo.GetJobDateFilteredJobLeadGridDataSource(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                    break;

                case "StatusType":
                    List<string> chosenStatusList = chkListBoxStatus.CheckedItems.OfType<string>().ToList();
                    dataGridView.DataSource = thisJobLeadRepo.GetJobStatusFilteredJobLeadGridDataSource(chosenStatusList);
                    break;

                case "ReferenceType":
                    dataGridView.DataSource = thisJobLeadRepo.GetJobRefFilteredJobLeadGridDatsSource(txtBoxSearchText.Text);
                    break;

                case "BrokerType":
                    dataGridView.DataSource = thisJobLeadRepo.GetJobBrokerFilteredJobLeadGridDataSource(txtBoxSearchText.Text);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// The function that shows/hides the search control panels
        /// </summary>
        private void SetSearchControls()
        {
            switch (searchType)
            {
                case "JobType":
                    pnlDateSearchOptions.Visible = false;
                    pnlJobTitleSearchOptions.Visible = true;
                    pnlStatusSearchOptions.Visible = false;
                    break;

                case "DateType":
                    pnlDateSearchOptions.Visible = true;
                    pnlJobTitleSearchOptions.Visible = false;
                    pnlStatusSearchOptions.Visible = false;
                    break;

                case "StatusType":
                    pnlDateSearchOptions.Visible = false;
                    pnlJobTitleSearchOptions.Visible = false;
                    pnlStatusSearchOptions.Visible = true;
                    break;

                case "ReferenceType":
                    pnlDateSearchOptions.Visible = false;
                    pnlJobTitleSearchOptions.Visible = true;
                    pnlStatusSearchOptions.Visible = false;
                    break;

                case "BrokerType":
                    pnlDateSearchOptions.Visible = false;
                    pnlJobTitleSearchOptions.Visible = true;
                    pnlStatusSearchOptions.Visible = false;
                    break;

                default:
                    pnlDateSearchOptions.Visible = false;
                    pnlJobTitleSearchOptions.Visible = false;
                    pnlStatusSearchOptions.Visible = false;
                    break;
            }
        }

        //Not on _CheckChanged as we do not want each button firing when one of
        //the radio button group is selected
        private void rBtnJobTitle_Click(object sender, EventArgs e)
        {
            searchType = "JobType";
            SetSearchControls();
        }

        private void rBtnJobDate_Click(object sender, EventArgs e)
        {
            searchType = "DateType";
            SetSearchControls();
        }

        private void rBtnJobStatus_Click(object sender, EventArgs e)
        {
            searchType = "StatusType";
            SetSearchControls();
        }

        private void rBtnJobReference_Click(object sender, EventArgs e)
        {
            searchType = "ReferenceType";
            SetSearchControls();
        }

        private void rBtnJobAgent_Click(object sender, EventArgs e)
        {
            searchType = "BrokerType";
            SetSearchControls();
        }

        private void dataGridAgencies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //A row has been double clicked. We need to get the BrokerID value, extract the Broker instance
            //and then pass this to the form to display the Broker.
            int brokerIDSelected = Convert.ToInt32(dataGridAgencies.SelectedRows[0].Cells["BrokerID"].Value.ToString());

            //PUT THIS IN A Using BLOCK?
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            iBroker brokerSelected = thisJobLeadRepo.GetBroker(brokerIDSelected);

            frmBroker newBrokerForm = new frmBroker(brokerSelected);
            newBrokerForm.ShowDialog();

            //Now reinitialise the Job Lead Grid
            ReloadAgencyBrokerGrid();
        }
    }
}
