using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = String.Empty;
            int charNums = input.Length;

            if (input.EndsWith("y"))
            {
                string newInput = input.Remove(input.Length - 1);
                result = newInput + "ies";
                
            }

            else if (input.EndsWith("o") 
                || input.EndsWith("s") 
                || input.EndsWith("x") 
                || input.EndsWith("z")
                || input.EndsWith("ch")
                || input.EndsWith("sh") )
            {
                result = input + "es";
            }

            else
            {
                result = input + "s";
            }

            Console.WriteLine(result);

        }
    }
}
