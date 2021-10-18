using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataSource
{
    public class EmployeeDataSourceTextfile : DataSourceBase
    {
        public override List<Employee> ProvideEmployeeContext()
        {
            Debug.WriteLine("Employees => From Textfile");

            //Handles fetching data from "Textfile"
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "rafael@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "John", Email = "smith@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "lindgren@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ernest", Email = "hemingway@gmail.com" });

            return Employees;
        }
    }
}
