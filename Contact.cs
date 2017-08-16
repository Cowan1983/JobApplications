using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace JobApplication
{
    //public abstract class Contact : iContact
    public class Contact : iContact
    {
        private string eMail;

        [Key]
        public int ContactID { get; set; }

        public int? BrokerID { get; set; }
        [ForeignKey("BrokerID")]
        public Broker Broker { get; set; }

        //This is what I want to use.        
        //public iName Name { get; set; }
        //public iAddress Address { get; set; }        

        //This is what I have to use.
        public Name Name { get; set; }
        public Address Address { get; set; }

        public string Position { get; set; }
        public string Email
        {
            get
            {
                return eMail;
            }
            set
            {
                //Do a minor validation to check the value has one, and only one, @ char
                //if (value.Count(x => x == '@') == 1)
                //Pass Email validation to a private function (perhaps better being moved to a common library)
                if(ValidateEmail(value))
                {
                    eMail = value;
                }
                else
                {
                    eMail = "";
                }
            }
        }
        public string MobileTelNo { get; set; }
        public string LandLineTelNo { get; set; }

        private List<Note> myContactNotes = new List<Note>();

        public List<Note> ContactNotes
        {
            get
            {
                return myContactNotes;
            }
            set
            {
                myContactNotes = value;
            }
        }

        //Default constructor
        public Contact() { }

        //Full constructor
        public Contact(Name myName, Address myAddress, string myPosition, string myEmail, string myMobileNo, string myLandLineNo)
        {
            Name = myName;
            Address = myAddress;
            Position = myPosition;
            Email = myEmail;
            MobileTelNo = myMobileNo;
            LandLineTelNo = myLandLineNo;
        }

        //Constructor that takes only a name and address
        public Contact(Name myName, Address myAddress)
            : this(myName, myAddress, "", "", "", "")
        {
        }

        public iContact Save()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            return thisJobLeadRepo.SaveContact(this);
        }

        private bool ValidateEmail(string myEmailAddress)
        {
            //Validate the email structure using a "Regular Expression"
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = reg.Match(myEmailAddress);

            return match.Success;
        }
    }
    
}
