using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public interface ICheckCampaignService
    {
        int CampaignExist(Campaign[] campaigns, int productId);
    }
}
