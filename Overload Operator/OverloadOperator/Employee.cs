using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
public class Employee
{
public int Id { get; set; }

public static bool operator ==(Employee x, Employee y)
{
return x.Id == y.Id;
}

public static bool operator !=(Employee x, Employee y)
{
return x.Id != y.Id;
}

public override bool Equals(object obj)
{
Employee Id = obj as Employee;
if (Id != null)
{
return Id == this;
}
return false;
}
public override int GetHashCode()
{
return base.GetHashCode();
}
}
}