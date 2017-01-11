using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    //public abstract class Name : iName
    public class Name : iName
    {
        //We need to declare index the Entity Framework will use as the table index.
        //As we have followed the EF convention of declaring it as <Class Name>ID, we
        //we don't need to use the 
        //[Key]
        //Date Annotation (requires "using System.ComponentModel.DataAnnotations;" in the header).
        //If we called it "UniqueNameIndex", we would need the [Key] annotation
        [Key]
        public int NameID { get; set; }

        //If we wanted a composite indexing, we would use
        /*
        [Key]
        [Column(Order=1)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Surname { get; set; }
        */

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get
            {
                //Construct a name string, allowing for the middle name to be missing
                return Title + " " + FirstName + " " + (MiddleName != "" ? (MiddleName + " ") : "") + Surname;
            }
        }

        //Default constructor
        public Name() { }

        //Construtor that takes title, first, middle and last name
        public Name(string myTitle, string myFirstName, string myMiddleName, string mySurname)
        {
            Title = myTitle;
            FirstName = myFirstName;
            MiddleName = myMiddleName;
            Surname = mySurname;
        }

        //Constructor that takes title, first and last name
        //Just call the constructor that takes a middle name and pass an empty string for the middle name
        public Name(string myTitle, string myFirstName, string mySurname)
            : this(myTitle, myFirstName, "", mySurname)
        {
        }

        public iName Save()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            return thisJobLeadRepo.SaveName(this);
        }
    }
    
}
