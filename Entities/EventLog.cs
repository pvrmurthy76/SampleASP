using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class EventLog
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Area { get; set; }
        public string EventType { get; set; }
        public string Message { get; set; }

    }
}
