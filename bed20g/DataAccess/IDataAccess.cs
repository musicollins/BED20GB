using bed20g.Model;
using System.Collections.Generic;

namespace bed20g.DataAccess
{
    public interface IDataAccess
    {
        List<Employee> GetEmployees();
    }
}