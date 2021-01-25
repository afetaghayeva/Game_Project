using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" Added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" Updated");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" deleted");
        }
    }
}
