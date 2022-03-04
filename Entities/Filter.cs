using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGen.Entities
{
    public class Filter
    {
        [Key]
        public Guid Id { get; set; }
        public string Label { get; set; }
        public ICollection<FilterOption> Options { get; set; }
        public ICollection<FilterCollection> Collections { get; set; }

    }
}
