using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            MathOperation n = new MathOperation();
            n.division(a);
            Console.ReadLine();

            n.multiplication(out b);
            Console.ReadLine();

            n.multiplication(out a, out b);
            Console.ReadLine();

            StaticExample.SampleStaticMethod();
            Console.ReadLine();
        }
    }
}