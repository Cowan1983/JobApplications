using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    //public abstract class JobLead : iJobLead
    public class JobLead : iJobLead
    {
        //ID for Entity Framework to know the record by
        public int JobLeadID { get; set; }

        //We can access this list of titles to populate drop down list components
        private static List<string> staticStatusList = new List<string>() { "Unset", "CV Sent", "Application Form Requested", "Application Form Sent", "Application Acknowledged", "Interview Arranged", "Closed" };

        
        public string JobTitle { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        //[ForeignKey ("Contact")]
        public int? AgencyContactID { get; set; }
        [ForeignKey ("AgencyContactID")]
        public Contact AgencyContact { get; set; }


        //[ForeignKey("Contact")]
        public int? EmployerContactID { get; set; }
        [ForeignKey("EmployerContactID")]
        public Contact EmployerContact { get; set; }


        //[ForeignKey("Broker")]
        public int? AgencyBrokerID { get; set; }
        [ForeignKey("AgencyBrokerID")]
        public Broker AgencyBroker { get; set; }


        //[ForeignKey("Broker")]
        public int? EmployerBrokerID { get; set; }
        [ForeignKey("EmployerBrokerID")]
        public Broker EmployerBroker { get; set; }


        public DateTime Date { get; set; }
        public string CVOrApplicationLocation { get; set; }
        public string CoverLetterLocation { get; set; }
        public string Ref_One { get; set; }
        public string Ref_Two { get; set; }
        public string Ref_Three { get; set; }
        public List<string> StatusList
        {
            get
            {
                return staticStatusList;
            }
        }

        private List<Note> myJobLeadNotes = new List<Note>();

        public List<Note> JobLeadNotes
        {
            get
            {
                return myJobLeadNotes;
            }
            set
            {
                myJobLeadNotes = value;
            }
        }

        public JobLead()
        {
            Date = DateTime.Now;
        }

        /// <summary>
        /// Save this instance of JobLead
        /// </summary>
        public void Save()
        {
            //This basically just gets punted to the JobRepo (as I don't want the JobLead implementation to handle it)
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();

            thisJobLeadRepo.SaveJobLead(this);
        }

        public object GetAllBrokers(bool isAgency)
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();

            if (isAgency == true)
            {
                return thisJobLeadRepo.GetAllAgencyBrokers();
            }
            else
            {
                return thisJobLeadRepo.GetAllEmployerBrokers();
            }

        }

        public Broker GetBroker(int thisBrokerID)
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            return thisJobLeadRepo.GetBroker(thisBrokerID);
        }

        public Contact GetContact(int thisContactID)
        {
            JobLeadRepo thisJobLeadRepo = new JobApplication.JobLeadRepo();
            return thisJobLeadRepo.GetContact(thisContactID);
        }
    }

}
