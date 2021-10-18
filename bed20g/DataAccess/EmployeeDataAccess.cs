using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataAccess
{
    public class EmployeeDataAccess
    {
        public EmployeeDataAccess()
        {

        }

        public List<Employee> GetEmployees()
        {
            //List<Employee> employees = dbContext.ProvideAllEmployees();
            //return employees;
            return new List<Employee>();
        }


    }
}
