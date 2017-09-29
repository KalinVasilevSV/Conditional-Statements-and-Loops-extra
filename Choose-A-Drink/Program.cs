using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_A_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            string drink = string.Empty;

            switch(profession)
            {
                case "athlete": drink = "Water";
                    break;
                case "businessman":
                case "businesswoman": drink = "Coffee";
                    break;
                case "softuni student": drink = "Beer";
                    break;
                default: drink = "Tea";
                    break;
            }

            Console.WriteLine(drink);
        }
    }
}
