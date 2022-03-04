using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class Collection
    {
        [Key]
        public Guid Id { get; set; }
        public string Handle { get; set; }
        public string Title { get; set; }
        public string ShopifyId { get; set; }
        public Guid ParentId { get; set; }

    }
}
