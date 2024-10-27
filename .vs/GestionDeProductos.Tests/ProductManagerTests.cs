using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GestionDeProductos;

namespace GestionDeProductos
{

    [TestFixture]
    public class ProductManagerTests
    {
        [Test]
        public void Product_Creation_ValidData_Success()
        {
            var product = new Product(1, "Notebook", 100000, "Electronica");
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Notebook", product.Name);
            Assert.AreEqual(100000, product.Price);
            Assert.AreEqual("Electronica", product.Category);
        }

        [Test]
        public void AddProduct_ProductAddedToList_Success()
        {
            var manager = new ProductManager();
            var product = new Product(1, "Notebook", 100000, "Electronica");
            manager.AddProduct(product);

            string expectedInfo = "ID: 1, Name: Notebook, Price: 100000, Category: Electronica";
            Assert.AreEqual(expectedInfo, manager.FindProductByName("Notebook"));
        }

        [Test]
        public void FindProductById_ProductExists_ReturnsProductInfo()
        {
            var manager = new ProductManager();
            var product = new Product(2, "Mouse", 50000, "Electronica");
            manager.AddProduct(product);

            var productInfo = manager.FindProductByName("Mouse");
            Assert.AreEqual("ID: 2, Name: Mouse, Price: 50000, Category: Electronica", productInfo);
        }
        

        [Test]
        public void CalculateTotalPrice_ElectronicsProduct_ReturnsPriceWith10PercentTax()
        {
            var manager = new ProductManager();
            var product = new Product(1, "Notebook", 100000, "Electronica");

            var totalPrice = manager.CalculateTotalPrice(product);
            Assert.AreEqual(110000, totalPrice);
        }

        [Test]
        public void CalculateTotalPrice_FoodProduct_ReturnsPriceWith5PercentTax()
        {
            var manager = new ProductManager();
            var product = new Product(2, "Arroz", 1000, "Alimentos");

            var totalPrice = manager.CalculateTotalPrice(product);
            Assert.AreEqual(1050m, totalPrice);
        }
    }

}
