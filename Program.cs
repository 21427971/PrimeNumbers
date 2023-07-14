using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {//Msimango KSI
        static void Main(string[] args)
        {// C# .NET program to check whether a given number is a prime number or not.
            int Num, count = 2; bool Prime = true;
            Console.Write("Enter a positive number : ");
            Num = int.Parse(Console.ReadLine());
            int maxdivider = (int)(Math.Sqrt(Num));
            while (Prime && (count <= maxdivider))
            {
                if (Num % count == 0)
                {
                    Prime = false;
                }
                count++;
            }
            Console.WriteLine($"Prime number?:{Prime}");
        }
    }
}
