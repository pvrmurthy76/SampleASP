using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class FilterOption
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FilterId")]
        public Guid FilterId { get; set; }
        public string Value { get; set; }

    }
}
