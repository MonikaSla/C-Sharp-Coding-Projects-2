using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 101;

            MathOperation n = new MathOperation();

            n.pickOne(a, b);
            n.pickOne(num2: b, num1: a);
            Console.ReadLine();
        }
    }
}