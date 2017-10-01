using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double volumePer100ml = volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy * volumePer100ml}kcal, {sugar * volumePer100ml}g sugars");
        }
    }
}
