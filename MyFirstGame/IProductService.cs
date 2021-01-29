using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public interface IProductService
    {
        void Add(Product product);
        void StockAdd(Product product,int howMany);
        void StockRemove(Product product,int howMany);
    }
}
