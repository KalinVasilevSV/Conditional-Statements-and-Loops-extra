using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var integer = 0;
            var integerCount = 0;


            while (true)
            {
                input= Console.ReadLine();

                try
                {
                    integer = int.Parse(input);
                    integerCount++;
                }
                catch
                {
                    break;
                }
            }

            Console.WriteLine(integerCount);
        }
    }
}
