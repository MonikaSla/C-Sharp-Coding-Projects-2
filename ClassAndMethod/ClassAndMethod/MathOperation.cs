using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
public class MathOperation
{
public int Sum (int num1, int num2)
{
var Total = num1 + num2;
return Total;
}
public int Product (int num1, int num2)
{
var Total = num1 * num2;
return Total;
}
public int Difference (int num1, int num2)
{
var Total = num1 - num2;
return Total;
}
}
}