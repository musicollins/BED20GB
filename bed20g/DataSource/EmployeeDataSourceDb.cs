using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bed20g.DataSource
{
    public class EmployeeDataSourceDb : DataSourceBase
    {
        public override List<Employee> ProvideEmployeeContext()
        {
            Debug.WriteLine("Employees => From Database");
            //Handles fetching data from "Database"
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "rafael@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "John", Email = "smith@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "lindgren@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ernest", Email = "hemingway@gmail.com" });

            return Employees;
        }

    }
}
