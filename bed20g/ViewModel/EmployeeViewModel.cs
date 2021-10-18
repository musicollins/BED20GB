using bed20g.DataAccess;
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
        private readonly EmployeeDataAccess _dataAccess;

        public List<Employee> Employees { get; set; }


        public EmployeeViewModel(EmployeeDataAccess dataAccess)
        {
            Employees = new List<Employee>();
            _dataAccess = dataAccess;
        }

        public List<Employee> LoadEmployees()
        {
            var employees = _dataAccess.GetEmployees();
            foreach (var item in employees)
            {
                Employees.Add(item);
            }
            return Employees;
        }

        
    }
}
