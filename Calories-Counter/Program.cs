using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIngredients = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;

            var totalCalories = 0;

            for (int i = 0; i < numberIngredients; i++)
            {
                ingredient= Console.ReadLine().ToLower();

                switch(ingredient)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break; 
                    case "pepper":
                        totalCalories += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");

        }
    }
}
