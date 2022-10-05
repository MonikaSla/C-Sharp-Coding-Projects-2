using System;
using System.Collections.Generic;

namespace ArrayAndListExercise
{
class Program
{
static void Main()
{
string[] array1 = new string[] { "Hello", "How are you", "I am fine" };

Console.WriteLine("Please select index 0, 1 or 2 to display corresponding text");
string index = Console.ReadLine();
int i = Convert.ToInt16(index);
bool indexTrueOrFalse = i == 0 && i == 1 && i == 2;

do
{
switch (i)
{
case 3:
Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
i = Convert.ToInt16(Console.ReadLine());
break;
case 4:
Console.WriteLine("Wrong index input! Try again.");
i = Convert.ToInt16(Console.ReadLine());
break;
case 0:
indexTrueOrFalse = true;
break;
case 1:
indexTrueOrFalse = true;
break;
case 2:
indexTrueOrFalse = true;
break;
default:
Console.WriteLine("Try another index.");
i = Convert.ToInt16(Console.ReadLine());
break;
}
}

while (!indexTrueOrFalse);

Console.WriteLine(array1[i]);
Console.ReadLine();

int[] array2 = new int[] { 500, 200, 2000 };

Console.WriteLine("Please select index 0, 1 or 2 to display corresponding integer");
string index1 = Console.ReadLine();
int i1 = Convert.ToInt16(index1);
bool indexTrueOrFalse1 = i1 == 0 && i1 == 1 && i1 == 2;

do
{
switch (i1)
{
case 3:
Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
i1 = Convert.ToInt16(Console.ReadLine());
break;
case 4:
Console.WriteLine("Wrong index input! Try again.");
i1 = Convert.ToInt16(Console.ReadLine());
break;
case 0:
indexTrueOrFalse1 = true;
break;
case 1:
indexTrueOrFalse1 = true;
break;
case 2:
indexTrueOrFalse1 = true;
break;
default:
Console.WriteLine("Try another index.");
i1 = Convert.ToInt16(Console.ReadLine());
break;
}
}

while (!indexTrueOrFalse1);

Console.WriteLine(array2[i1]);
Console.ReadLine();

List<string>
    myList = new List<string>();
            myList.Add("What is your name?");
            myList.Add("How old are you?");
            myList.Add("Where do you come from?");

            Console.WriteLine("Please select index 0, 1 or 2 to display corresponding content");
            string index2 = Console.ReadLine();
            int i2 = Convert.ToInt16(index2);
            bool indexTrueOrFalse2 = i1 == 0 && i1 == 1 && i1 == 2;

            do
            {
                switch (i2)
                {
                    case 3:
                        Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input! Try again.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse2 = true;
                        break;
                    case 1:
                        indexTrueOrFalse2 = true;
                        break;
                    case 2:
                        indexTrueOrFalse2 = true;
                        break;
                    default:
                        Console.WriteLine("Try another index.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse2);

            Console.WriteLine(myList[i2]);
            Console.ReadLine();
        }
    }
}