using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public partial class Product
    {
        public void Show()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Price : {Price}");
            SetPriceWithTax();
            SetPriceWithDiscount();
            Console.WriteLine($"Price With Tax : {PriceWithTax}");
            Console.WriteLine($"Price With Discount : {PriceWithDiscount}");
        }

        partial void SetPriceWithDiscount()
        {
            PriceWithDiscount = Price - Price * Discount / 100;
        }

        partial void SetPriceWithTax()
        {
            PriceWithTax = Price + Price * Tax / 100;
        }
    }
}
