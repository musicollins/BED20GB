using Autofac;
using bed20g.DataAccess;
using bed20g.DataSource;
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
            var autofacContainer = new AutofacDIContainer();
            var diContainer = autofacContainer.Container();
            var employeeViewModel = diContainer.Resolve<EmployeeViewModel>();
            var productViewModel = diContainer.Resolve<ProductViewModel>();

            //var viewModel = new EmployeeViewModel(new EmployeeDataAccess(new EmployeeDataSourceTextfile()));


            employeeViewModel.LoadEmployees();
            foreach (var employee in employeeViewModel.Employees)
            {
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.Email);
                Console.WriteLine();
            }

            Console.WriteLine("##########################");

            productViewModel.LoadProducts();
            foreach (var products in productViewModel.Products)
            {
                Console.WriteLine(products.Id);
                Console.WriteLine(products.Name);
                Console.WriteLine(products.Category);
                Console.WriteLine();
            }



        }
    }
}
