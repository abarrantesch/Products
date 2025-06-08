using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {

        private string _filePath = "product.txt";

        public List<Product> ReadProducts()
        {   //leer la lista de productos desde un txt y cargarla en una lista.
            var products = new List<Product>();
            return products;

            if (File.Exists(_filePath))
            {
                var lines=File.ReadAllLines(_filePath);

                foreach(var line in lines)
                {
                    var parts=line.Split(',');
                    var product = new Product();
                    product.Id = Int32.Parse(parts[0]);
                    product.Name = parts[1];
                    product.Price = Double.Parse(parts[3]);
                    product.Stock = Int32.Parse(parts[2]);
                    products.Add(product);
                }
            }
        }

        public void SaveProduct(Product product)
        {
            // guardar el producto en un txt
            var line=product.Id + "," + product.Name + "," + product.Stock + "," + product.Price;

            File.AppendAllText(line, _filePath);
        }
    }
}
