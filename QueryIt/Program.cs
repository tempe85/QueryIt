using System;
using System.Data.Entity;
using System.Linq;

namespace QueryIt
{
  class Program
  {
    static void Main(string[] args)
    {
      //var repository = new Repository<Employee>(); // talks to a real database!
      // AddEmployee(repository)
      // AddManager(repository)
      //CountEmployees(repository)
      //PrintAllPeople(repository)


      Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDb>());
      using (IRepository<Employee> employeeRepository = new SqlRespository<Employee>(new EmployeeDb()))
      {
        AddEmployees(employeeRepository);
        CountEmployees(employeeRepository);
      }

    }

    private static void CountEmployees(IRepository<Employee> employeeRepository)
    {
      Console.WriteLine(employeeRepository.FindAll().Count());
    }

    private static void AddEmployees(IRepository<Employee> employeeRepository)
    {
      employeeRepository.Add(new Employee { Name = "Scott" });
      employeeRepository.Add(new Employee { Name = "Chris" });
      employeeRepository.Commit();
    }
  }
}
