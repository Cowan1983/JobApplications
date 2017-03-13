using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class frmNote : Form
    {

        public iNote myNote;

        //public frmNote()
        private frmNote()
        {
            InitializeComponent();
        }

        //public frmNote(iNote thisNote)
        private frmNote(iNote thisNote)
        {
            InitializeComponent();
        }

        public frmNote(List<Note> exisitingNotes)
        {
            InitializeComponent();

            ShowExistingNotes(exisitingNotes);

            myNote = InstanceFactory.Note();

            txtBoxNoteDate.Text = myNote.NoteDate.ToLongDateString();
        }

        private void CloseNoteForm()
        {
            this.Close();
        }

        private void btnCancelCloseNote_Click(object sender, EventArgs e)
        {
            CloseNoteForm();
        }

        private void btnUpdateCloseNote_Click(object sender, EventArgs e)
        {
            //Update the instance
            myNote.NoteText = rTextBoxNote.Text;

            //Save the new Note instance.
            myNote = myNote.Save();

            CloseNoteForm();
        }

        private void ShowExistingNotes(List<Note> myExisitingNotes)
        {
            StringBuilder allExistingNotes = new StringBuilder();
            allExistingNotes.Append(@"{\rtfl\ansi");

            //Iterate through the existing notes list and build a single big string to show.
            foreach (iNote thisExsitingNote in myExisitingNotes)
            {
                allExistingNotes.Append(@"\b ");
                allExistingNotes.Append(thisExsitingNote.NoteDate.ToString("dd MMMM yyyy HH:mm"));
                allExistingNotes.Append(@"\b0 \line ");
                allExistingNotes.Append(thisExsitingNote.NoteText);
                allExistingNotes.Append(@"\b0 \line ");
                allExistingNotes.Append(@"\b0 \line ");
            }

            rTxtBoxAllNotes.Rtf = allExistingNotes.ToString();
        }
    }
}
