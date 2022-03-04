using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CashGen.Entities
{
    public class Feature
    {
        [Key]
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }

    }
}
