using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Entities;

namespace Game_Project.Abstract
{
    interface ISellingService
    {
        void Buy(Player player,Game game,Campaign campaign=null);
    }
}
