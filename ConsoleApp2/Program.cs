using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    #region Static Constructor

    //    class Car
    //    {
    //        public static DateTime GlobalStartTime;
    //        static Car()
    //        {
    //            GlobalStartTime = DateTime.Now;
    //            throw new Exception();
    //            Console.WriteLine($@"Static Constructor called
    //                        Global Start Time : {GlobalStartTime.ToLongTimeString()}");
    //        }

    //        public Car(int id)
    //        {
    //            Console.WriteLine("Parametric Constructor Called");
    //            Id = id;
    //        }
    //        public int Id { get; set; }

    //        public void Drive()
    //        {
    //            TimeSpan elapsedTime = DateTime.Now - GlobalStartTime;
    //            Console.WriteLine($@"
    //                CAR ID : {Id} is starting its works 
    //                {elapsedTime.Seconds} seconds
    //                after global start time
    //                {GlobalStartTime.ToLongTimeString()}
    //");
    //        }


    //    }
    //    public class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Car car = null;
    //            for (int i = 0; i < 10; i++)
    //            {
    //                car = new Car(i);
    //                Thread.Sleep(500);
    //            }
    //            car.Drive();
    //        }
    //    }
    #endregion


    #region Partial Classes and Methods

    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount account = new BankAccount();
            //account.Id = 1;
            //account.Name = "John";
            //Console.WriteLine(BankAccount.IBANPref);
            //account.Start();

            /*
             * 
             * Product Id , Name , Price , Discount , Tax
             * Show
             * GetPriceWithDiscount
             * GetPriceWithTax
             * GetPriceWithDiscountAndTax
             * 
             * DISCOUNT 10
             * TAX      15
             * 
             */

            Product product = new Product
            {
                Id = 1,
                Name = "Iphone 11 pro max",
                Price = 1450
            };
            product.Discount = 20;
            product.Show();

        }
    }

    #endregion
}

