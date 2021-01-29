using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product with Id: "+ product.Id + " and name : "+ product.Name +" added");
        }

        public void StockAdd(Product product,int howMany)
        {
            product.UnitInStock += howMany;
            Console.WriteLine(howMany + " units of " + product.Name + " added into stock");
        }

          public void StockRemove(Product product, int howMany)
        {
            product.UnitInStock -= howMany;
            Console.WriteLine(howMany + " units of " + product.Name + " removed from stock");
        }
    }
}
