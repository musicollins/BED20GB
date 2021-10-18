using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.DataSource
{
    public class ProductDataSourceMockData : ProductDataSourceBase
    {
        public override List<Product> ProviderProductContext()
        {
            Debug.WriteLine("Products => From MockData");

            //Handles fetching data from "MockData"
            Products.Add(new Product() { Id = Guid.NewGuid(), Name = "iPhone4", Category = "Electronics" });
            Products.Add(new Product() { Id = Guid.NewGuid(), Name = "Samsung Galaxy s10", Category = "Electronics" });
            Products.Add(new Product() { Id = Guid.NewGuid(), Name = "Xiaomi mi 11", Category = "Electronics" });
            Products.Add(new Product() { Id = Guid.NewGuid(), Name = "Oppo", Category = "Electronics" });

            return Products;
        }
    }
}
