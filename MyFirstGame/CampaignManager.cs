using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName + " added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName + " deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + " " + campaign.CampaignName + " updated.");
        }
    }
}
