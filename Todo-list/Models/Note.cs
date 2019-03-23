using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo_list.Models
{
    public enum NoteStatus { Todo, Doing, Done }
    public class Note
    {
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "The field can not be empty")]
        [MaxLength(500, ErrorMessage = "The field can take up to 500 symbols")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public NoteStatus Status { get; set; }

        public Note()
        {
            CreatedAt = DateTime.Now;
            Status = NoteStatus.Todo;
        }
    }
}