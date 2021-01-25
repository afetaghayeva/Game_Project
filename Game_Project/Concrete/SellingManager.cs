using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    class SellingManager:ISellingService
    {
        public void Buy(Player player)
        { 
            Console.WriteLine(player.FirstName+" oyunu satin aldi");
        }
    }
}
