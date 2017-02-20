using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Tax
    {
        public Tax()
        {
            ProductTax = new HashSet<ProductTax>();
        }

        public int TaxId { get; set; }
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<ProductTax> ProductTax { get; set; }
    }
}
