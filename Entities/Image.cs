using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public string Base64 { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public string Src { get; set; }

    }
}
