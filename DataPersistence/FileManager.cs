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
        public List<Product> ReadProducts()
        {   //leer la lista de productos desde un txt y cargarla en una lista.
            var products = new List<Product>();
            return products;
        }

        public void SaveProduct(Product product)
        {
            // guardar el producto en un txt
        }
    }
}
