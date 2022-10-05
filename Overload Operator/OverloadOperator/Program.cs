using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
class Program
{
static void Main(string[] args)
{
Employee n = new Employee();
n.Id = 1001;

Employee n1 = new Employee();
n.Id = 1001;

Console.WriteLine(n == n1);
Console.ReadLine();

}
}
}