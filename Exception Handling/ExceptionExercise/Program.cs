using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Please enter your age.");
try
{
bool validAnswer = false;
int age = 1;
while (!validAnswer)
{
validAnswer = int.TryParse(Console.ReadLine(), out age);
if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
}
if (age <= 0)
{
throw new AgeException();
}

DateTime currentYear = DateTime.Now;
int CurrentYear = Convert.ToInt32(currentYear.Year);
int YearOfBorn = CurrentYear - age;
Console.WriteLine("You were borned in the year of {0}", YearOfBorn);
Console.ReadLine();
}
catch (AgeException)
{
Console.WriteLine("An error occurred. Please enter positive digitals only, no decimals.");
Console.ReadLine();
return;
}
catch (Exception)
{
Console.WriteLine("An error occurred. Please contact your System Administrator.");
Console.ReadLine();
return;
}


}
}
}