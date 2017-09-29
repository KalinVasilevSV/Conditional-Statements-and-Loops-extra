using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var noun = Console.ReadLine();
            var pluralNoun = string.Empty;

            var lastSymbol = noun[noun.Length-1];
            bool isGroupOne = false;
            bool isGroupTwo = false;
            bool isGroupRest = false;

            if(lastSymbol=='y')
            {
                isGroupOne = true;
            }
            else if(lastSymbol=='o'||lastSymbol=='h'||lastSymbol=='s'||lastSymbol=='x'||lastSymbol=='z')
            {
                isGroupTwo = true;
            }
            else
            {
                isGroupRest = true;
            }

            if(isGroupOne)
            {
                for (int i = 0; i < noun.Length-1; i++)
                {
                    pluralNoun += noun[i];
                }
                pluralNoun += "ies";
            }
            else if(isGroupTwo)
            {
                pluralNoun = noun + "es";
            }
            else if(isGroupRest)
            {
                pluralNoun = noun + "s";
            }

            Console.WriteLine(pluralNoun);

        }
    }
}
