using OCPLibrary;
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
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Test1", LastName = "Test1" },
                new ManagerModel { FirstName = "Test2", LastName = "Test2" },
                new ExecutiveModel { FirstName = "Test3", LastName = "Test3" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            //Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            
            Console.ReadLine();
        }
    }
}
