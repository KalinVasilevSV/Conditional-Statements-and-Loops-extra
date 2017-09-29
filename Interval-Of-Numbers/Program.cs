using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            var smallerNum = 0;
            var largerNum = 0;

            if(firstNum>secondNum)
            {
                largerNum = firstNum;
                smallerNum = secondNum;
            }
            else
            {
                largerNum = secondNum;
                smallerNum = firstNum;
            }

            for (int i = smallerNum; i <= largerNum; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
