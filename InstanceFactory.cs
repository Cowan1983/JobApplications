using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    //This class is responsible for providing the concrete classes that implement the interfaces passed between modules/forms
    //We are just duplicating the constructors here (which gives us the chance to "hide" constructors if we want).
    static class InstanceFactory
    {
        public static iAddress Address()
        {
            return new Address();
        }

        public static iAddress Address(string myBodyText, string myCity, string myRegion, string myCountry, string myPostcode)
        {
            return new Address(myBodyText, myCity, myRegion, myCountry, myPostcode);
        }

        public static iBroker Broker()
        {
            return new Broker();
        }

        public static iContact Contact()
        {
            return new Contact();
        }

        public static iContact Contact(iName myName, iAddress myAddress)
        {
            return new Contact((Name)myName, (Address)myAddress);
        }

        public static iContact Contact(iName myName, iAddress myAddress, string myPosition, string myEmail, string myMobileNo, string myLandLineNo)
        {
            return new Contact((Name)myName, (Address)myAddress, myPosition, myEmail, myMobileNo, myLandLineNo);
        }

        public static iName Name()
        {
            return new Name();
        }

        public static iName Name(string myTitle, string myFirstName, string mySurname)

        {
            return new Name(myTitle, myFirstName, mySurname);
        }

        public static iName Name(string myTitle, string myFirstName, string myMiddleName, string mySurname)
        {
            return new Name(myTitle, myFirstName, myMiddleName, mySurname);
        }

        public static iJobLead JobLead()
        {
            return new JobLead();
        }

        public static iNote Note()
        {
            return new Note();
        }

        public static iNote Note(string myNoteText)
        {
            return new Note(myNoteText);
        }
    }
}
