using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.ViewModel
{
    class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public EmployeeViewModel()
        {

        }

        public List<Employee> LoadEmployees()
        {
            //var employees = dataAccess.GetEmployees();
            return Employees;
        }
    }
}
