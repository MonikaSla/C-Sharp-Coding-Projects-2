using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
public class Employee<T>
    : Person
    {
    public List<T> things { get; set; }

        public override void SayName()
        {
            string fullName = firstName + lastName;
            Console.WriteLine("Name: " + fullName);
            Console.ReadLine();
        }
        public Employee()
        {
            firstName = "Sample";
            lastName = "Student";
        }
    }
}