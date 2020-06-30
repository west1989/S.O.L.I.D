﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
  public class ExecutiveAccounts : IAccounts
  {
    public EmployeeModel Create(IApplicantModel person)
    {
      EmployeeModel output = new EmployeeModel();

      output.FirstName = person.FirstName;
      output.LastName = person.LastName;
      output.EmailAddress = $"{person.FirstName}.{person.LastName}@acmecorp.com";

      output.IsExecutive = true;
      output.IsManager = true;

      return output;
    }
  }
}
