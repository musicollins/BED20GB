using Autofac;
using bed20g.DataAccess;
using bed20g.Db;
using bed20g.Startup;
using bed20g.ViewModel;
using System;

namespace bed20g
{
    class Program
    {


        static void Main(string[] args)
        {
            var autofacContainer = new AutofacContainer();
            var iocContainer = autofacContainer.Container();
            var viewModel = iocContainer.Resolve<EmployeeViewModel>();
            viewModel.LoadEmployees();
            foreach (var employee in viewModel.Employees)
            {
                Console.WriteLine(employee.Name);
            }

        }
    }
}
