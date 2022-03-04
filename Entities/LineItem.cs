using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class LineItem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public long variant_id { get; set; }
        public string title { get; set; }
        public int quantity { get; set; }
        public string sku { get; set; }
        public long product_id { get; set; }
        public Guid ProductKey { get; set; }
        public string fulfilment { get; set; }
        public decimal line_price { get; set; }
        public long line_id { get; set; }

    }
}
