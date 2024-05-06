using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randnumgen
{
    public class mainrandom
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int number = rand.Next(100);

            Console.WriteLine("Generate random number within the limit of 100 is:" + number);

            int num2 = rand.Next(100, 1000);

            Console.WriteLine("Generate random number between 100 to 1000 is :" + num2);

            double num3 = rand.NextDouble();

            Console.WriteLine("Random number between 0.0 to 0.1 is :" + num3);
        }
    }
}

