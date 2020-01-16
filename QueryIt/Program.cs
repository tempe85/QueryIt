using System;
using System.Data.Entity;

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
      throw new NotImplementedException();
    }

    private static void AddEmployees(IRepository<Employee> employeeRepository)
    {
      throw new NotImplementedException();
    }
  }
}
