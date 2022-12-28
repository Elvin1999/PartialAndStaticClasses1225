using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceWithTax { get; set; }
        public double PriceWithDiscount { get; set; }
        public double Discount { get; set; } = DiscountGlobal;
        public double Tax { get; set; } = TaxGlobal;

        partial void SetPriceWithDiscount();
        partial void SetPriceWithTax();
    }
}
