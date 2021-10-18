using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataSource
{
    public abstract class ProductDataSourceBase
    {
        public List<Product> Products { get; set; }

        public ProductDataSourceBase()
        {
            Products = new List<Product>();
        }

        public abstract List<Product> ProviderProductContext();
    }
}
