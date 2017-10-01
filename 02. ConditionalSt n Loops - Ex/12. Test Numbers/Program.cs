using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int sum = (i * j) * 3;
                    currentSum += sum;
                    counter++;

                    if (currentSum >= maxSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {currentSum} >= {maxSum}");
                        return;
                    }

                }
                
            }
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {currentSum}");
        }
    }
}
