using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;

namespace Game_Project.Entities
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Percent { get; set; }
    }
}
