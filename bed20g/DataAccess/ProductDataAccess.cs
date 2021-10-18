using bed20g.DataSource;
using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataAccess
{
    public class ProductDataAccess : IProductDataAccess
    {
        private readonly ProductDataSourceBase _dataSource;
        public ProductDataAccess(ProductDataSourceBase dataSource)
        {
            _dataSource = dataSource;
        }
        public List<Product> GetProducts()
        {
            List<Product> employees = _dataSource.ProviderProductContext();
            return employees;
        }
    }
}
