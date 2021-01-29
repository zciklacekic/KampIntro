using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class SalesManager : ISalesService
    {
 
        public void Sell(Players players, Product product, int amount)
        {
             
              if (amount < product.UnitInStock)
            {
                Console.WriteLine(amount + " Units of " + product.Name + " is sold to : " + players.FirstName + " with a price of " + product.UnitPrice);
                (new ProductManager()).StockRemove(product, amount);
            }
            else
            {
                Console.WriteLine("Not enough stock on the product" + product.Name);
                Console.WriteLine("Amount requested : " + amount);
                Console.WriteLine("Unit in stock :" + product.UnitInStock);
            }
        }

        public void SellCampaign(Players players, Product product, int amount, Campaign campaign)
        {
            if (amount < product.UnitInStock)
            {
                Console.WriteLine(amount + " Units of " + product.Name + " is sold to : " + players.FirstName + " with a price of " + campaign.CampaignPrice + " using " + campaign.CampaignName);
                (new ProductManager()).StockRemove(product, amount);
            }
            else
            {
                Console.WriteLine("Not enough stock on the product" + product.Name);
                Console.WriteLine("Amount requested : " + amount);
                Console.WriteLine("Unit in stock :" + product.UnitInStock);
            }
        }
    }
}
