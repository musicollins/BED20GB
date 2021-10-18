using Autofac;
using bed20g.DataAccess;
using bed20g.Db;
using bed20g.ViewModel;

namespace bed20g.Startup
{
    public class AutofacContainer
    {
        public IContainer Container()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeDataAccess>().AsSelf();
            builder.RegisterType<EmployeeViewModel>().AsSelf();
            builder.RegisterType<EmployeeDB>().AsSelf();

            return builder.Build();
        }
    }
}
