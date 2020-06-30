using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      IManager accountingVP = new CEO();

      accountingVP.FirstName = "Test1";
      accountingVP.LastName = "Test1";
      accountingVP.CalculatePerHourRate(4);

      Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${ accountingVP.Salary }/hour.");

      IManaged emp = new Manager();

      emp.FirstName = "Test2";
      emp.LastName = "Test2";
      emp.AssignManager(accountingVP);
      emp.CalculatePerHourRate(2);

      Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
      
      

      Console.ReadLine();
    }
  }
}
