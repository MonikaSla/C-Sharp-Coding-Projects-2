using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers for the math operation, one at a time. No need to enter anything for the second number.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int total;
            MathOperation n = new MathOperation();
            total = n.Sum(a, b);
            Console.WriteLine("The sum of " + a + " , " + 100 + " and " + "optional number " + b + " is " + total);
            total = n.Sum(a);
            Console.WriteLine("The sum of " + a + " , " + 100 + " and " + "optional number " + b + " is " + total);
            Console.ReadLine();
        }
    }
}