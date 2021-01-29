using System;

namespace MyFirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PersonValidationManager());
            Players players = new Players();
            players.FirstName = "ZAFER";
            players.LastName = "ÇIKLAÇEKİÇ";
            players.NickName = "ZAZA";
            players.NationalityId = "12345678901";
            players.YearOfBirth = 1976;
            playerManager.Add(players);

            Product product = new Product { Id = 1, Name = "MyFirstGame", Version = 1, Edition = "First edition", UnitPrice = 10, UnitInStock = 100 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);

            productManager.StockAdd(product, 5);
            Campaign campaign = new Campaign();
            SalesManager salesManager = new SalesManager();
            salesManager.Sell(players, product, 1);
            CampaignManager campaignManager = new CampaignManager();
            //Campaign[] campaigns = new Campaign[] { CampaignId = 1, CampaignName = "Ne alırsan 5 lira kampanyası", CampaignPrice = 5, ProductId = 1 };
            campaign.CampaignId = 1; campaign.CampaignName = "Ne alırsan 5 lira kampanyası"; campaign.CampaignPrice = 5; campaign.ProductId = 1;
            campaignManager.Add(campaign);

            campaign.CampaignId = 1; campaign.CampaignName = "Ne alırsan 7 lira kampanyası"; campaign.CampaignPrice = 7; campaign.ProductId = 1;
            campaignManager.Update(campaign);
            salesManager.SellCampaign(players, product, 2, campaign);
            campaignManager.Delete(campaign);
            
        }
    }
}
            