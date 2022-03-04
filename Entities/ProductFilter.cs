using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class ProductFilter
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public string Value { get; set; }

    }
}
