using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCal = 0;

            for (int i = 0; i < n; i++)
            {
                string ingridients = Console.ReadLine().ToLower();
                switch (ingridients)
                {
                    case "cheese":
                        totalCal += 500;
                        break;
                    case "tomato sauce":
                        totalCal += 150;
                        break;
                    case "salami":
                        totalCal += 600;
                        break;
                    case "pepper":
                        totalCal += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}
