using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication
{
    //public abstract class Contact : iContact
    public class Contact : iContact
    {
        private string eMail;

        [Key]
        public int ContactID { get; set; }

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
                if (value.Count(x => x == '@') == 1)
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
    }
    
}
