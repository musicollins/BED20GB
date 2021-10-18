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

        public List<Employee> Employees { get; private set; }

        private readonly IDataAccess _dataAccess;
        public EmployeeViewModel(IDataAccess dataAccess)
        {
            
            Employees = new List<Employee>();
            _dataAccess = dataAccess;
        }

        public void LoadEmployees()
        {
            var employees = _dataAccess.GetEmployees();
            foreach (var item in employees)
            {
                Employees.Add(item);
            }
            
        }

        
    }
}
