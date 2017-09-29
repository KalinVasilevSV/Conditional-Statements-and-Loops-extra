using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var charOne = char.Parse(Console.ReadLine());
            var charTwo = char.Parse(Console.ReadLine());
            var magicChar = char.Parse(Console.ReadLine());

            var lowerChar = 'a';
            var higherChar = 'a';

            if(charOne>charTwo)
            {
                lowerChar = charTwo;
                higherChar = charOne;
            }
            else
            {
                lowerChar = charOne;
                higherChar = charTwo;
            }

            for (char firstChar = lowerChar; firstChar <= higherChar; firstChar++)
            {
                for (char secondChar = lowerChar; secondChar <= higherChar; secondChar++)
                {
                    for (char thirdChar = lowerChar; thirdChar <= higherChar; thirdChar++)
                    {
                        if((firstChar!=magicChar)&&(secondChar!=magicChar)&&(thirdChar!=magicChar))
                        {
                            Console.Write($"{firstChar}{secondChar}{thirdChar} ");
                        }
                    }
                }
            }

        }
    }
}
