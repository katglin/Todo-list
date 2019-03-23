using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo_list.Models
{
    public static class Seed
    {
        public static List<Note> SeedNotes()
        {
            IEnumerable<Note> notes = new List<Note>
            {
                new Note
                {
                    CreatedAt = DateTime.Now.AddHours(-45),
                    Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                    	"incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation " +
                    	"ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit " +
                    	"in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat " +
                    	"non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Status = NoteStatus.Done
                },
                new Note
                {
                    CreatedAt = DateTime.Now.AddHours(-27),
                    Message = "Prepare layout",
                    Status = NoteStatus.Doing
                },
                new Note
                {
                    CreatedAt = DateTime.Now,
                    Message = "Landing page:\n - Home view\n - About us\n - Contacts",
                    Status = NoteStatus.Todo
                }
            };
            return notes.ToList();
        }
    }
}