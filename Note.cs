using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class Note : iNote
    {
        public int NoteID { get; set; }

        public string NoteText { get; set; }

        public DateTime NoteDate { get; set; }

        public Note()
        {

            NoteDate = DateTime.Now;

        }

        public Note(string myNoteText) : this()
        {
            NoteText = myNoteText;
        }

        public iNote Save()
        {
            JobLeadRepo thisJobLeadRepo = new JobLeadRepo();
            return thisJobLeadRepo.SaveNote(this);

        }
    }
}
