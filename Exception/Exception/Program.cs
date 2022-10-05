using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
{
List<int>
    numbers = new List<int>
        () { 3, 5, 8, 4 };

        //Console.WriteLine("Pick a number to divide each number in the list by.");
        //int numberOne = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    int numberTwo = numbers[i] / numberOne;
        //    Console.WriteLine(numbers[i] + " divided by " + numberOne + " equals " + numberTwo);
        //    Console.ReadLine();
        //}

        try
        {
            Console.WriteLine("Pick a number to divide each number in the list by.");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                int numberTwo = numbers[i] / numberOne;
                Console.WriteLine(numbers[i] + " divided by " + numberOne + " equals " + numberTwo);
                Console.ReadLine();
            }



        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }
}