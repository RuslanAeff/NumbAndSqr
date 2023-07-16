using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbAndSqr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 9, 8, 6, 5 , 4 ,3, 2, 1 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int b = numbers[i];
                int a = numbers[i] * numbers[i];
                Console.WriteLine("{" + "Number=" + b + "," + " "  + "SqrNo=" + a +"}" +" " );

            }
        }
    }
}
