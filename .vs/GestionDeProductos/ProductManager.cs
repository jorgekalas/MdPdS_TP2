using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }


        public string FindProductByName(string name)
        {
            var product = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                return $"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}";
            }

            return "Producto no encontrado";
        }

        public decimal CalculateTotalPrice(Product product)
        {
            decimal taxRate = product.Category == "Electronica" ? 0.10m : 0.05m;
            return product.Price + (product.Price * taxRate);
        }
    }
}
