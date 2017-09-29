using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var boundary = int.Parse(Console.ReadLine());

            var totalSum = 0;
            int combinationsCount = 0;
            bool exceededBoundary = false;

            for (int firstNum = N; firstNum >= 1; firstNum--)
            {
                for (int secondNum = 1; secondNum <= M; secondNum++)
                {
                    if (totalSum<boundary)
                    {
                        totalSum= totalSum+(firstNum * secondNum) * 3;
                        combinationsCount++;
                    }
                    else
                    {
                        exceededBoundary = true;
                    }
                }
            }

            if(exceededBoundary)
            {
                Console.WriteLine($"{combinationsCount} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }

        }
    }
}
