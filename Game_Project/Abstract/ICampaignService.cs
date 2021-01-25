using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Entities;

namespace Game_Project.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
