using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    //public abstract class Broker : iBroker
    public class Broker : iBroker
    {

        //A broker will have a list of contacts
        private List<Contact> myContacts = new List<Contact>();
        public List<Contact> Contacts
        {
            get
            {
                return myContacts;
            }
            set
            {
                myContacts = value;
            }
        }

        //If this is an Agency broker, this will be the list of employers they work with.
        //If this is an Employer broker, this will be the list of agencies they work with
        private List<Broker> myBrokers = new List<Broker>();
        public List <Broker> Brokers
        {
            get
            {
                return myBrokers;
            }
            set
            {
                myBrokers = value;
            }
        }

        private List<Note> myBrokerNotes = new List<Note>();

        public List<Note> BrokerNotes
        {
            get
            {
                return myBrokerNotes;
            }
            set
            {
                myBrokerNotes = value;
            }
        }

        public int BrokerID { get; set; }

        //A simple boolean to say if this broker is an agency (otherwise it is an employer)
        public bool IsAgency { get; set; }
        //public bool IsEmployer { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string LandLineTelNo { get; set; }
        public string Website { get; set; }

        public List<Broker> GetAllUnassociatedBrokers()
        {
            //This gets passed on to the JobRepo
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();

            return thisJobLeadRepo.GetAllUnassociatedBrokers(myBrokers, IsAgency);

        }

        //public void Save()
        public Broker Save()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            //thisJobLeadRepo.SaveBroker(this);
            return thisJobLeadRepo.SaveBroker(this);
        }
    }

}
