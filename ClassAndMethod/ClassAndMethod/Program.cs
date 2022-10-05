using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer for the math operations.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 32;
            int total;
            MathOperation n = new MathOperation();

            total = n.Sum(a, b);
            Console.WriteLine("The sum of " + a + " and " + b + " is " + total);
            total = n.Product(a, b);
            Console.WriteLine("The product of " + a + " and " + b + " is " + total);
            total = n.Difference(a, b);
            Console.WriteLine("The difference of " + a + " and " + b + " is " + total);
            Console.ReadLine();

        }
    }
}