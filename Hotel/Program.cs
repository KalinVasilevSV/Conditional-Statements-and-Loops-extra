using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            var studioPerNight = 0.00;
            var doublePerNight = 0.00;
            var suitePerNight = 0.00;

            var studioDiscount = 0.00;
            var doubleDiscount = 0.00;
            var suiteDiscount = 0.00;

            switch(month)
            {
                case "may":
                case "october":
                    studioPerNight = 50.00;
                    doublePerNight = 65.00;
                    suitePerNight = 75.00;
                    if(nights>7)
                    {
                        studioDiscount = 0.05;
                    }
                    break;
                case "june":
                case "september":
                    studioPerNight = 60.00;
                    doublePerNight = 72.00;
                    suitePerNight = 82.00;
                    if(nights>14)
                    {
                        doubleDiscount = 0.10;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioPerNight = 68.00;
                    doublePerNight = 77.00;
                    suitePerNight = 89.00;
                    if(nights>14)
                    {
                        suiteDiscount = 0.15;
                    }
                    break;
            }

            bool freeStudioNight = (month == "september" || month == "october")&&(nights>7);

            var totalStudio = 0.00;
            var totalDouble = 0.00;
            var totalSuite = 0.00;

            if (freeStudioNight)
            {
                totalStudio = (nights-1) * studioPerNight;
            }
            else
            {
                totalStudio = nights * studioPerNight;
            }
            totalStudio = totalStudio - totalStudio * studioDiscount;

            totalDouble = nights * doublePerNight;
            totalDouble = totalDouble - totalDouble * doubleDiscount;

            totalSuite = nights * suitePerNight;
            totalSuite = totalSuite - totalSuite * suiteDiscount;

            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalSuite:f2} lv.");
            
        }
    }
}
