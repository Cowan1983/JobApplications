using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication
{
    //public abstract class Address : iAddress
    public class Address : iAddress
    {
        [Key]
        public int AddressID { get; set; }

        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string BodyText { get; set; }

        public string FullAddress
        {
            get
            {
                //Construct an address string, allowing for any value to be missing
                string builtAddress = (BodyText != "" ? (BodyText + ",\n") : "") + (City != "" ? (City + ",\n") : "") + (Region != "" ? (Region + ",\n") : "") + (Country != "" ? (Country + ",\n") : "") + (Postcode != "" ? Postcode : "");
                if (builtAddress != "") builtAddress += ".";

                return builtAddress;
            }
        }

        //Default constructor
        public Address()
        {
        }

        //Constructor that takes all the address
        public Address(string myBodyText, string myCity, string myRegion, string myCountry, string myPostcode)
        {
            BodyText = myBodyText;
            City = myCity;
            Region = myRegion;
            Country = myCountry;
            Postcode = myPostcode;
        }

        public iAddress Save()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            return thisJobLeadRepo.SaveAddress(this);
        }
    }
   
}
