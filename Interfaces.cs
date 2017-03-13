using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public interface iName
    {
        int NameID { get; }
        string FirstName { get; set; }
        string Surname { get; set; }
        string MiddleName { get; set; }
        string Title { get; set; }
        string FullName { get; }
        iName Save();
    }

    public interface iAddress
    {
        int AddressID { get; }
        string Postcode { get; set; }
        string Country { get; set; }
        string Region { get; set; }
        string City { get; set; }
        string BodyText { get; set; }
        string FullAddress { get; }
        iAddress Save();
    }

    public interface iContact
    {
        //iName Name { get; set; }
        //iAddress Address { get; set; }
        int ContactID { get; }
        Name Name { get; set; }
        Address Address { get; set; }
        string Position { get; set; }
        string Email { get; set; }
        string MobileTelNo { get; set; }
        string LandLineTelNo { get; set; }
        List<Note> ContactNotes { get; set; }
        iContact Save();
    }

    public interface iBroker
    {
        int BrokerID {get; }
        List<Contact> Contacts { get; set; }
        List<Broker> Brokers { get; set; }
        string Name { get; set; }
        Address Address { get; set; }
        string LandLineTelNo { get; set; }
        string Website { get; set; }
        bool IsAgency { get; set; }
        List<Broker> GetAllUnassociatedBrokers();
        List<Note> BrokerNotes { get; set; }
        Broker Save();
    }

    public interface iJobLead
    {
        int JobLeadID { get; set; }
        string JobTitle { get; set; }
        string Source { get; set; }
        string Status { get; set; }
        Contact AgencyContact { get; set; }
        int? AgencyContactID { get; set; }
        Contact EmployerContact { get; set; }
        int? EmployerContactID { get; set; }
        Broker AgencyBroker { get; set; }
        int? AgencyBrokerID { get; set; }
        Broker EmployerBroker { get; set; }
        int? EmployerBrokerID { get; set; }
        DateTime Date { get; set; }
        string CVOrApplicationLocation { get; set; }
        string CoverLetterLocation { get; set; }
        string Ref_One { get; set; }
        string Ref_Two { get; set; }
        string Ref_Three { get; set; }
        List<string> StatusList { get; }
        List<Note> JobLeadNotes { get; set; }

        void Save();
        object GetAllBrokers(bool isAgency);
        Broker GetBroker(int thisBrokerID);
        Contact GetContact(int thisContactID);
    }

    public interface iNote
    {
        string NoteText { get; set; }
        DateTime NoteDate { get; set; }

        iNote Save();
    }
}
