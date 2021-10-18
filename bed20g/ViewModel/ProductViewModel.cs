using bed20g.DataAccess;
using bed20g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bed20g.ViewModel
{
    public class ProductViewModel
    {
        public List<Product> Products { get; private set; }

        private readonly IProductDataAccess _dataAccess;
        public ProductViewModel(IProductDataAccess dataAccess)
        {

            Products = new List<Product>();
            _dataAccess = dataAccess;
        }

        public void LoadProducts()
        {
            var products = _dataAccess.GetProducts();
            foreach (var item in products)
            {
                Products.Add(item);
            }

        }
    }
}
