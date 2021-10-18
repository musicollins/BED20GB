﻿using bed20g.DataSource;
using bed20g.Db;
using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataAccess
{
    public class EmployeeDataAccess : IDataAccess
    {
        private DataSourceBase _dataSource;
        public EmployeeDataAccess(DataSourceBase dataSource)
        {
            _dataSource = dataSource;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = _dataSource.ProvideEmployeeContext();
            return employees;
        }


    }
}
