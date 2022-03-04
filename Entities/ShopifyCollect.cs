using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class ShopifyCollect
    {
        [Key]
        public long Id { get; set; }
        public long ShopifyId { get; set; }
        public long CollectionId { get; set; }
        public long ProductId { get; set; }

    }
}
