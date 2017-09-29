using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var lastN = 0;
            var lastM = 0;
            bool foundMagicNum = false;
            var combinationsCount = 0;

            var lowerNum = 0;
            var higherNum = 0;

            if(N>M)
            {
                lowerNum = M;
                higherNum = N;
            }
            else
            {
                lowerNum = N;
                higherNum = M;
            }
            
            for (int firstNum = lowerNum; firstNum <= higherNum; firstNum++)
            {
                for (int secondNum = lowerNum; secondNum <= higherNum; secondNum++)
                {
                    if (firstNum + secondNum == magicNum)
                    {
                        foundMagicNum = true;
                        lastN = firstNum;
                        lastM = secondNum;
                    }

                    combinationsCount++;
                }
            }

            if(foundMagicNum)
            {
                Console.WriteLine($"Number found! {lastN} + {lastM} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
