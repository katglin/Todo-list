using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo_list.Models
{
    public static class Database
    {
        public static List<Note> Notes;
        static Database()
        {
            Notes = Seed.SeedNotes();
        }
    }
}