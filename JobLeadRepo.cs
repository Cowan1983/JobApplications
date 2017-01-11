﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    /// <summary>
    /// This class is for all the information flows from and to the DataContext
    /// </summary>
    class JobLeadRepo
    {
        public iJobLead GetJobLead(int myJobLeadID)
        {
            //Here is where we decide the depth of information extracted for a Job Lead instance
            using (var ctx = new JobLeadContext())
            {
                iJobLead thisFullJobLead = ctx.JobLeads
                    .Include("AgencyBroker")
                    .Include("AgencyBroker.Brokers")
                    .Include("AgencyBroker.Address")
                    .Include("AgencyBroker.Contacts.Address")
                    .Include("AgencyBroker.Contacts.Name")
                    .Include("EmployerBroker")
                    .Include("EmployerBroker.Brokers")
                    .Include("EmployerBroker.Address")
                    .Include("EmployerBroker.Contacts.Address")
                    .Include("EmployerBroker.Contacts.Name")
                    .Where(s => s.JobLeadID == myJobLeadID)
                    .FirstOrDefault<iJobLead>();

                //Apparently it is OK to return in a Using block. The finalising code will still be called.
                return thisFullJobLead;
            }
        }

        public object GetJobLeadGridDatasource()
        {
            using (var ctx = new JobLeadContext())
            {
                var allLeadsTable = from m in ctx.JobLeads
                select new { m.JobLeadID, m.JobTitle, m.Date, m.Status, m.Ref_One, m.Ref_Two, m.Ref_Three, Agency = m.AgencyBroker.Name };

                return allLeadsTable.ToList();
            }
        }

        public object GetAllEmployerBrokers()
        {
            return GetAllBrokers(false);
        }

        public object GetAllAgencyBrokers()
        {
            return GetAllBrokers(true);
        }
        
        public object GetAllBrokers(bool isAgency)
        {
            using (var ctx = new JobLeadContext())
            {
                var allBrokersList = from m in ctx.Brokers
                                     where m.IsAgency == isAgency
                                     select m;

                return allBrokersList.ToList();
            }
        }

        public Broker GetBroker(int thisBrokerID)
        {
            using (var ctx = new JobLeadContext())
            {
                Broker thisBroker = ctx.Brokers
                    .Include("Address")
                    .Include("Contacts.Address")
                    .Include("Contacts.Name")
                    .Include("Brokers")
                    .Where(m => m.BrokerID == thisBrokerID)
                    .FirstOrDefault<Broker>();

                return thisBroker;
            }
        }

        public Contact GetContact(int thisContactID)
        {
            using (var ctx = new JobLeadContext())
            {
                Contact thisContact = ctx.Contacts
                    .Include("Address")
                    .Include("Name")
                    .Where(m => m.ContactID == thisContactID)
                    .FirstOrDefault<Contact>();

                return thisContact;
            }
        }

        public void SaveJobLead(JobLead myJobLead)
        {
            //We will do this within a single Context
            using (var ctx = new JobLeadContext())
            {                

                //If we have a JobLeadID of 0 (zero), then this is a new job.
                if (myJobLead.JobLeadID == 0)
                {

                    var contextJobLeadEntity = ctx.JobLeads.Include("AgencyBroker").Include("AgencyContact").Include("EmployerBroker").Include("EmployerBroker").Where(s => s.JobLeadID == myJobLead.JobLeadID).FirstOrDefault<JobLead>();

                    if (myJobLead.AgencyBrokerID != 0)
                    {
                        var newBrokerEntity = ctx.Brokers.Where(s => s.BrokerID == myJobLead.AgencyBrokerID).FirstOrDefault<Broker>();
                        myJobLead.AgencyBroker = newBrokerEntity;
                    }

                    if (myJobLead.EmployerBrokerID != 0)
                    {
                        var newBrokerEntity = ctx.Brokers.Where(s => s.BrokerID == myJobLead.EmployerBrokerID).FirstOrDefault<Broker>();
                        myJobLead.EmployerBroker = newBrokerEntity;
                    }

                    if (myJobLead.AgencyContactID != 0)
                    {
                        var newContactEntity = ctx.Contacts.Where(s => s.ContactID == myJobLead.AgencyContactID).FirstOrDefault<Contact>();
                        myJobLead.AgencyContact = newContactEntity;
                    }

                    if (myJobLead.EmployerContactID != 0)
                    {
                        var newContactEntity = ctx.Contacts.Where(s => s.ContactID == myJobLead.EmployerContactID).FirstOrDefault<Contact>();
                        myJobLead.EmployerContact = newContactEntity;
                    }
                    
                    //Add it to the context.
                    ctx.JobLeads.Add((JobLead)myJobLead); //As this requires the form to know what the actual class is, we definitely need to move this out of the form.
                }
                else //Otherwise we update the existing one.
                {
                    //First, get the whole job lead entity
                    var contextJobLeadEntity = ctx.JobLeads.Include("AgencyBroker").Include("AgencyContact").Include("EmployerBroker").Include("EmployerBroker").Where(s => s.JobLeadID == myJobLead.JobLeadID).FirstOrDefault<JobLead>();

                    //Set all the JobLead entity level values.
                    contextJobLeadEntity.Status = myJobLead.Status;
                    contextJobLeadEntity.JobTitle = myJobLead.JobTitle;
                    contextJobLeadEntity.Source = myJobLead.Source;
                    contextJobLeadEntity.CVOrApplicationLocation = myJobLead.CVOrApplicationLocation;
                    contextJobLeadEntity.CoverLetterLocation = myJobLead.CoverLetterLocation;
                    contextJobLeadEntity.Ref_One = myJobLead.Ref_One;
                    contextJobLeadEntity.Ref_Two = myJobLead.Ref_Two;
                    contextJobLeadEntity.Ref_Three = myJobLead.Ref_Three;

                    //Now we attach the AgentBroker, AgentContact, EmployerBroker and EmployerContact sub entities

                    if(myJobLead.AgencyBrokerID != 0)
                    {
                        var newBrokerEntity = ctx.Brokers.Where(s => s.BrokerID == myJobLead.AgencyBrokerID).FirstOrDefault<Broker>();
                        contextJobLeadEntity.AgencyBroker = newBrokerEntity;
                    }

                    if(myJobLead.EmployerBrokerID != 0)
                    {
                        var newBrokerEntity = ctx.Brokers.Where(s => s.BrokerID == myJobLead.EmployerBrokerID).FirstOrDefault<Broker>();
                        contextJobLeadEntity.EmployerBroker = newBrokerEntity;
                    }

                    if (myJobLead.AgencyContactID != 0)
                    {
                        var newContactEntity = ctx.Contacts.Where(s => s.ContactID == myJobLead.AgencyContactID).FirstOrDefault<Contact>();
                        contextJobLeadEntity.AgencyContact = newContactEntity;
                    }

                    if (myJobLead.EmployerContactID != 0)
                    {
                        var newContactEntity = ctx.Contacts.Where(s => s.ContactID == myJobLead.EmployerContactID).FirstOrDefault<Contact>();
                        contextJobLeadEntity.EmployerContact = newContactEntity;
                    }
                }

                //Finally, we save the changes to the changes made in the context.
                ctx.SaveChanges();
                
            }
        }

        public List<Broker> GetAllUnassociatedBrokers(List<Broker> currentAssociatedBrokers, bool isAgency)
        {
            using (var ctx = new JobLeadContext())
            {
                
                var brokerIDs = currentAssociatedBrokers.Select(x => x.BrokerID).ToArray();
                //We invert the isAgency value so that we only find Employer brokers if this is am Agency broker, and vice versa (that's your actual Latin)
                var allUnassociatedBrokers = ctx.Brokers.Where(x => !brokerIDs.Contains(x.BrokerID) && x.IsAgency == !isAgency );

                return allUnassociatedBrokers.ToList();
            }
        }

        //public void SaveBroker(Broker myBroker)
        public Broker SaveBroker(Broker myBroker)
        {
            //We will do this within a single Context
            using (var ctx = new JobLeadContext())
            {
                if (myBroker.BrokerID == 0)
                {
                    //Extract and attach the Address from the context
                    if (myBroker.Address != null)
                    {
                        var contextAddressEntity = ctx.Addresses.Where(s => s.AddressID == myBroker.Address.AddressID).FirstOrDefault<Address>();
                        myBroker.Address = contextAddressEntity;
                    }

                    //Extract and add all the Contacts from the context
                    List<Contact> newContactList = new List<Contact>();
                    foreach(Contact thisContact in myBroker.Contacts)
                    {
                        var contextContactEntity = ctx.Contacts.Include("Name").Include("Address").Where(s => s.ContactID == thisContact.ContactID).FirstOrDefault<Contact>();
                        newContactList.Add(contextContactEntity);
                    }
                    myBroker.Contacts = newContactList;

                    //Extract and add all the Brokers from the context
                    List<Broker> newBrokerList = new List<Broker>();
                    foreach(Broker thisBroker in myBroker.Brokers)
                    {
                        var newBrokerEntity = ctx.Brokers.Include("Brokers").Where(s => s.BrokerID == thisBroker.BrokerID).FirstOrDefault<Broker>();
                        newBrokerList.Add(newBrokerEntity);
                        //Create the reverse Broker<->Broker connection
                        newBrokerEntity.Brokers.Add(myBroker);
                    }
                    myBroker.Brokers = newBrokerList;

                    //Add this broker to the context 
                    ctx.Brokers.Add((Broker)myBroker);

                    ctx.SaveChanges();

                    //We can get the generated id now myBroker.BrokerID.
                    //Or we can pass myBroker back?
                    return myBroker;
                }
                else
                {
                    var contextBrokerEntity = ctx.Brokers.Include("Address").Include("Contacts").Include("Brokers").Where(s => s.BrokerID == myBroker.BrokerID).FirstOrDefault<Broker>();

                    //We need to re-attach the Address, all the Contacts and all the Brokers
                    //Everything else if at the entity level, and so does not need refound.

                    //The address
                    //Extract and attach the Address from the context
                    if (myBroker.Address != null)
                    {
                        var contextAddressEntity = ctx.Addresses.Where(s => s.AddressID == myBroker.Address.AddressID).FirstOrDefault<Address>();
                        contextBrokerEntity.Address = contextAddressEntity;
                    }

                    //The contacts
                    foreach (Contact thisContact in myBroker.Contacts)
                    {

                    }

                    //The brokers
                    foreach (Broker thisBroker in myBroker.Brokers)
                    {

                        //As we don't (currently) allow the removal of brokers, we just need to handle the addition of new brokers

                        //Get the context version of the current associated broker
                        var newBrokerEntity = ctx.Brokers.Include("Brokers").Where(s => s.BrokerID == thisBroker.BrokerID).FirstOrDefault<Broker>();

                        //See if it is already attached to the context version of this broker
                        if (!contextBrokerEntity.Brokers.Contains(newBrokerEntity))
                        {
                            contextBrokerEntity.Brokers.Add(newBrokerEntity);
                        }

                        //See if the connection between brokers in the other direction is also present
                        if (!newBrokerEntity.Brokers.Contains(contextBrokerEntity))
                        {
                            newBrokerEntity.Brokers.Add(contextBrokerEntity);
                        }

                    }

                    ctx.SaveChanges();

                    return contextBrokerEntity;
                }

            }
        }

        public iAddress SaveAddress(Address myAddress)
        {
            //We will do this within a single Context
            using (var ctx = new JobLeadContext())
            {
                //Currently we have no sub-entities that we need to find and attach

                if(myAddress.AddressID == 0)
                {
                    //New address
                    ctx.Addresses.Add(myAddress);

                    ctx.SaveChanges();

                    //Having saved the address, we pass it back so we can add it to whatever class requested it to be made.
                    return myAddress;
                }
                else
                {
                    //Update existing address
                    var contextAddressEntity = ctx.Addresses.Where(s => s.AddressID == myAddress.AddressID).FirstOrDefault<Address>();

                    contextAddressEntity.BodyText = myAddress.BodyText;
                    contextAddressEntity.City = myAddress.City;
                    contextAddressEntity.Region = myAddress.Region;
                    contextAddressEntity.Country = myAddress.Country;
                    contextAddressEntity.Postcode = myAddress.Postcode;

                    ctx.SaveChanges();

                    return contextAddressEntity;
                }
            }
        }

        public iName SaveName(Name myName)
        {
            //We will do this within a single Context
            using (var ctx = new JobLeadContext())
            {
                //Currently we have no sub-entities that we need to find and attach

                if (myName.NameID == 0)
                {
                    //New address
                    ctx.Names.Add(myName);

                    ctx.SaveChanges();

                    //Having saved the address, we pass it back so we can add it to whatever class requested it to be made.
                    return myName;
                }
                else
                {
                    //Update existing name
                    var contextNameEntity = ctx.Names.Where(s => s.NameID == myName.NameID).FirstOrDefault<Name>();

                    contextNameEntity.Title = myName.Title;
                    contextNameEntity.FirstName = myName.FirstName;
                    contextNameEntity.MiddleName = myName.MiddleName;
                    contextNameEntity.Surname = myName.Surname;

                    ctx.SaveChanges();

                    return contextNameEntity;
                }
            }

        }

        public iContact SaveContact(Contact myContact)
        {
            using (var ctx = new JobLeadContext())
            {
                //If we have a ContactID of 0 (zero), then this is a new job.
                if (myContact.ContactID == 0)
                {

                    if (myContact.Name.NameID != 0)
                    {
                        var newNameEntity = ctx.Names.Where(s => s.NameID == myContact.Name.NameID).FirstOrDefault<Name>();
                        myContact.Name = newNameEntity;
                    }

                    if(myContact.Address.AddressID != 0)
                    {
                        var newAddressEntity = ctx.Addresses.Where(s => s.AddressID == myContact.Address.AddressID).FirstOrDefault<Address>();
                        myContact.Address = newAddressEntity;
                    }

                    //Add it to the context.
                    ctx.Contacts.Add((Contact)myContact);

                    ctx.SaveChanges();

                    return myContact;
                }
                else //Otherwise we update the existing one.
                {
                    //Get the Contact entity we are updating
                    var contextContactEntity = ctx.Contacts.Include("Name").Include("Address").Where(s => s.ContactID == myContact.ContactID).FirstOrDefault<Contact>();

                    //Set all the JobLead entity level values.
                    contextContactEntity.Position = myContact.Position;
                    contextContactEntity.Email = myContact.Email;
                    contextContactEntity.LandLineTelNo = myContact.LandLineTelNo;
                    contextContactEntity.MobileTelNo = myContact.MobileTelNo;

                    //Now we attach the Name and Address sub entities

                    if (myContact.Name.NameID != 0)
                    {
                        var newNameEntity = ctx.Names.Where(s => s.NameID == myContact.Name.NameID).FirstOrDefault<Name>();
                        contextContactEntity.Name = newNameEntity;
                    }

                    if (myContact.Address.AddressID != 0)
                    {
                        var newAddressEntity = ctx.Addresses.Where(s => s.AddressID == myContact.Address.AddressID).FirstOrDefault<Address>();
                        contextContactEntity.Address = newAddressEntity;
                    }

                    ctx.SaveChanges();

                    return contextContactEntity;
                }
                
            }

        }

    }
}
