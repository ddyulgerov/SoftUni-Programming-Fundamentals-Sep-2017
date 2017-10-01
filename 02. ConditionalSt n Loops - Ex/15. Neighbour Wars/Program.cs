using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoStarHealth = 100;
            int goshoStartHealth = 100;

            int round = 1;

            while (peshoStarHealth > 0 && goshoStartHealth > 0)
            {
                if (round % 2 != 0)
                {
                    goshoStartHealth -= peshoDamage;

                    if (goshoStartHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoStartHealth} health.");
                    }

                    else
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }

                }
                else
                {
                    peshoStarHealth -= goshoDamage;

                    if (peshoStarHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoStarHealth} health.");
                        
                    }

                    else
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }

                }

                if (round % 3 == 0)
                {
                    goshoStartHealth += 10;
                    peshoStarHealth += 10;
                }

                round++;
            }


        }
    }
}
