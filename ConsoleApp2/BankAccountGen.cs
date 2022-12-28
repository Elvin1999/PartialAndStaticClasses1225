using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Default Contructor");
        }

        public void Start()
        {
            Console.WriteLine("Started Program");
            ShowAccount();
            UpdateAccount();
        }

        partial void ShowAccount()
        {
            Console.WriteLine("Kapital Bank Hesab 1000 AZN");
        }


        partial void UpdateAccount()
        {
            Console.WriteLine("Updated Account");
        }
    }
}
