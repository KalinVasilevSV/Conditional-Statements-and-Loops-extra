using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var n1 = a;
            var n2 = n1 + 1;
            var n3 = n2 + 1;
            var n4 = n3 + 1;
            var n5 = n4 + 1;

            bool foundCombination = false;

            for (int firstNum = n1; firstNum <= (b-4); firstNum++)
            {
                for (int secondNum = n2; secondNum <= (b-3); secondNum++)
                {
                    for (int thirdNum = n3; thirdNum <= (b-2); thirdNum++)
                    {
                        for (int fourthNum = n4; fourthNum <= (b-1); fourthNum++)
                        {
                            for (int fifthNum = n5; fifthNum <= b; fifthNum++)
                            {
                                if ((a <= firstNum) && (firstNum< secondNum) && (secondNum< thirdNum) && (thirdNum< fourthNum) && (fourthNum< fifthNum) && (fifthNum<= b))
                                {
                                    Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {fourthNum} {fifthNum}");
                                    foundCombination = true;
                                }
                            }
                        }
                    }
                }
            }

            if(!foundCombination)
            {
                Console.WriteLine("No");
            }
        }
    }
}
