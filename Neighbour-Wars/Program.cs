using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoAttack = int.Parse(Console.ReadLine());
            var goshoAttack= int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var round = 1;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if(round%2==1)
                {
                    goshoHealth -= peshoAttack;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                    }
                }
                else
                {
                    peshoHealth -= goshoAttack;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                    }
                }

                if(round%3==0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

                round++;
            }

        }
    }
}
