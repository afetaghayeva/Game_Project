using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    class SellingManager:ISellingService
    {
        public void Buy(Player player, Game game, Campaign campaign = null)
        {
            decimal price = game.Price - game.Price * campaign.Percent/100;
            Console.WriteLine(player.FirstName+" bought "+game.GameName+" game for "+price+" $");
        }
    }
}
