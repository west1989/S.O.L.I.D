﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
  public class Accounts : IAccounts
  {
    public EmployeeModel Create(IApplicantModel person)
    {
      EmployeeModel output = new EmployeeModel();

      output.FirstName = person.FirstName;
      output.LastName = person.LastName;
      output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

      //if (person.TypeOfEmployee == EmployeeType.Manager)
      //{
      //  output.IsManager = true;
      //}

      //switch (person.TypeOfEmployee)
      //{
      //  case EmployeeType.Staff:
      //    break;
      //  case EmployeeType.Manager:
      //    output.IsManager = true;
      //    break;
      //  case EmployeeType.Excecutive:
      //    output.IsManager = true;
      //    output.IsExecutive = true;
      //    break;
      //  default:
      //    break;
      //}

      return output;
    }
  }
}
