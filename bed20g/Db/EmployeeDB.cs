using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.Db
{
    public class EmployeeDB
    {
        public List<Employee> Employees { get; set; }

        public EmployeeDB()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> ProvideEmployeeContext()
        {
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "rafael@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "John", Email = "smith@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "lindgren@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ernest", Email = "hemingway@gmail.com" });
            return Employees;
        }

    }
}
