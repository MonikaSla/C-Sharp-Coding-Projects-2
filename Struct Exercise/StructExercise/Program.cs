using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 10.003M;
            Console.WriteLine(n.Amount);
            Console.ReadLine();
        }
    }
}