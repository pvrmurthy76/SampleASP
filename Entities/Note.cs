using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }
        public Guid LinkedId { get; set; }
        public Guid UserId { get; set; }
        public DateTime NoteTime { get; set; }
        public string NoteText { get; set; }
    }
}
