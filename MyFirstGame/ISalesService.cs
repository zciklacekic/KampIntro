using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public interface ISalesService
    {
        void Sell(Players players, Product product, int amount);
        void SellCampaign(Players players, Product product, int amount, Campaign campaign);

    }
}
