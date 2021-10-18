using bed20g.DataSource;
using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.Db
{
    public class EmployeeDataSourceMockdata : DataSourceBase
    {
        public override List<Employee> ProvideEmployeeContext()
        {
            Debug.WriteLine("Employees => From Mockdata");

            //Handles fetching data from "MockData"
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "rafael@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "John", Email = "smith@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "lindgren@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ernest", Email = "hemingway@gmail.com" });

            return Employees;
        }
    }
}
