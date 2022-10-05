using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod3
{
class MathOperation
{
public int Sum(int num1, int optionalint = 4)
{
var Total = num1 + 100 + optionalint;
return Total;
}



}
}