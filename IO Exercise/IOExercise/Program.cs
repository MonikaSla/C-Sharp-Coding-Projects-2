using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOexercise
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Please enter a number.");
string text = Console.ReadLine();
File.WriteAllText(@"C:\Users\wt051453\Desktop\Folder1\Logs\log.txt", text);
using (StreamReader file = File.OpenText(@"C:\Users\wt051453\Desktop\Folder1\Logs\log.txt"))
{
string number = "";

while ((number = file.ReadLine())!= null)
{
Console.WriteLine(number);
}
}
Console.ReadLine();
}
}
}