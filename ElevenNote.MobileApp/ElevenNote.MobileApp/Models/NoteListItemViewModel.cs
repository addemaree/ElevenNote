using System;
using System.Collections.Generic;
using System.Text;

namespace ElevenNote.MobileApp.Models
{
    public class NoteListItemViewModel
    {
        //<summary>
        //The Note's ID on the server
        //</summary>
        public int NoteId { get; set; }

        //<summary>
        //This is the notes Title
        //</summary>
        public string Title { get; set; }

        //<summary>
        //The icon to use when displaying the note
        //</summary>
        public string StarImage { get; set; }
    }
}
