using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    class PlayerManager:IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName+" Added");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " Updated");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " Deleted");
        }
    }
}
