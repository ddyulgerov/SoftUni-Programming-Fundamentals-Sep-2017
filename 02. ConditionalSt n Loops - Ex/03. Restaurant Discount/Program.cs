using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double smallHallNormal = (2500 + 500) * 0.95;
            double smallHallGold = (2500 + 750) * 0.90;
            double smallHallPlatinum = (2500 + 1000) * 0.85;
            double terraceHallNormal = (5000 + 500) * 0.95;
            double terraceHallGold = (5000 + 750) * 0.90;
            double terraceHallPlatinum = (5000 + 1000) * 0.85;
            double greatHallNormal = (7500 + 500) * 0.95;
            double greatHallGold = (7500 + 750) * 0.90;
            double greatHallPlatinum = (7500 + 1000) * 0.85;


            if (groupSize <= 50 & groupSize > 0)
            {
                switch (package)
                {
                    case "normal":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(smallHallNormal / groupSize):F2}$");
                        break;
                    case "gold":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(smallHallGold / groupSize):F2}$");
                        break;
                    case "platinum":
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(smallHallPlatinum / groupSize):F2}$");
                        break;
                }
            }

            else if (groupSize > 50 & groupSize <= 100)
            {
                switch (package)
                {
                    case "normal":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {(terraceHallNormal / groupSize):F2}$");
                        break;
                    case "gold":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {(terraceHallGold / groupSize):F2}$");
                        break;
                    case "platinum":
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {(terraceHallPlatinum / groupSize):F2}$");
                        break;
                }
            }

            else if (groupSize > 100 & groupSize <= 120)
            {
                switch (package)
                {
                    case "normal":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {(greatHallNormal / groupSize):F2}$");
                        break;
                    case "gold":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {(greatHallGold / groupSize):F2}$");
                        break;
                    case "platinum":
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {(greatHallPlatinum / groupSize):F2}$");
                        break;
                }
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");  
            }


        }
    }
}
