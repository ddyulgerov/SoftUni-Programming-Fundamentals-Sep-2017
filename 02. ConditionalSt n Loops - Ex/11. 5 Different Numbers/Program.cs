using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            if (Math.Abs(start - end) >= 5)
            {
                for (int i1 = start; i1 <= end - 4; i1++)
                {
                    for (int i2 = i1 + 1; i2 <= end - 3; i2++)
                    {
                        for (int i3 = i2 + 1; i3 <= end - 2; i3++)
                        {
                            for (int i4 = i3 + 1; i4 <= end - 1; i4++)
                            {
                                for (int i5 = i4 + 1; i5 <= end; i5++)
                                {
                                    Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                                }

                            }

                        }

                    }


                }
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

