using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class CheckCampaignService : ICheckCampaignService
    {
        public int CampaignExist(Campaign[] campaigns,int productId)
        {
            int price=0;
            if (campaigns.Length==0)
            {
                
            }
            else
            {
                foreach (var campaign in campaigns)
                {
                    if (productId == campaign.ProductId)
                    {
                        price = campaign.CampaignPrice;
                    }
                }
            }

            return price;

        }
    }
}
