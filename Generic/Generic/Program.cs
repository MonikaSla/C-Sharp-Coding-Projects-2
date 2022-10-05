using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> n = new Employee<string>();
            n.things = new List<string>() { "Employee Identification", "Office Space", "Office Supplies", "Computer" };
            Employee<int> m = new Employee<int>();
            m.things = new List<int>() { 1, 1, 3, 1 };

            foreach (string thing in n.things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }

            foreach (int thing in m.things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
        }
    }
}