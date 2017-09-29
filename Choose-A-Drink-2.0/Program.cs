using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_A_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantiy = int.Parse(Console.ReadLine());
            var price = -1d;

            string drink = string.Empty;

            switch (profession.ToLower())
            {
                case "athlete":
                    drink = "Water";
                    price = 0.70d;
                    break;
                case "businessman":
                case "businesswoman":
                    drink = "Coffee";
                    price = 1.00d;
                    break;
                case "softuni student":
                    drink = "Beer";
                    price = 1.70d;
                    break;
                default:
                    drink = "Tea";
                    price = 1.20d;
                    break;
            }

            var totalPrice = quantiy * price;

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
