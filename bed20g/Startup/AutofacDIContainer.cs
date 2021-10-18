using Autofac;
using bed20g.DataAccess;
using bed20g.DataSource;
using bed20g.Db;
using bed20g.ViewModel;

namespace bed20g.Startup
{
    public class AutofacDIContainer
    {
        public IContainer Container()
        {
            //Creating Autofac Container
            var container = new ContainerBuilder();

            //Employee Dependencies
            container.RegisterType<EmployeeViewModel>().AsSelf();
            container.RegisterType<EmployeeDataAccess>().As<IDataAccess>();
            container.RegisterType<EmployeeDataSourceDb>().As<DataSourceBase>();

            //Product Dependencies
            container.RegisterType<ProductViewModel>().AsSelf();
            container.RegisterType<ProductDataAccess>().As<IProductDataAccess>();
            container.RegisterType<ProductDataSourceMockData>().As<ProductDataSourceBase>();

            return container.Build();

        }
    }
}
