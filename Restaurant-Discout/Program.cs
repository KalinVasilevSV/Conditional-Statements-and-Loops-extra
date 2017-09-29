using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discout
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower();

            string hall = string.Empty;
            var price = 0d;

            if (group < 50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (group < 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if (group < 120)
            {
                hall = "Great Hall";
                price += 7500;
            }
            else
            {
                hall = "declined";
            }


            if (hall == "declined")
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (package == "normal")
                {
                    price += 500;
                    price = price - price * 0.05;
                }
                else if (package == "gold")
                {
                    price += 750;
                    price = price - price * 0.10;
                }
                else if (package == "platinum")
                {
                    price += 1000;
                    price = price - price * 0.15;
                }

                var pricePerPerson = price / group;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
