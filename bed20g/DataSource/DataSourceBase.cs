using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataSource
{
    public abstract class DataSourceBase
    {
        public List<Employee> Employees { get; set; }

        public DataSourceBase()
        {
            Employees = new List<Employee>();
        }

        public abstract List<Employee> ProvideEmployeeContext();
    }
}
