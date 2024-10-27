using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }

        public Product(int id, string name, decimal price, string category)
        {
            if (price < 0)
                throw new ArgumentException("El precio no puede ser negativo");

            //Supongamos que solamente tenemos estas dos categorías, como dice el enunciado, para que, si se ingresa una diferente, nos arroje la exception.
            if (category != "Electronica" && category != "Alimentos")
                throw new ArgumentException("La categoría debe ser 'Electronica' o 'Alimentos'");

            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
