using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManager
    {
        public void AddProduct(Product product)
        {
            //Aplicar validaciones
            if(string.IsNullOrEmpty(product.Name))
            {
                throw new Exception("El nombre no puede estar vacio");
            }

            if (product.Price < 1)
            {
                throw new Exception("El precio debe ser mayor que 0");    
            }

            if (product.Stock < 1)
            {
                throw new Exception("El stock debe ser mayor que 0");
            }

            //Si pasa las validaciones, guardar el producto en un txt

            var fm=new FileManager();
            fm.SaveProduct(product);
        }
        public List<Product> GetProducts()
        {
            var list=new List<Product>();
            return list;
        }
    }
}
