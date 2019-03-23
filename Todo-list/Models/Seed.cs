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
                    Message = "Create database",
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
                    Message = "Landing page",
                    Status = NoteStatus.Todo
                }
            };
            return notes.ToList();
        }
    }
}