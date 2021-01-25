using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Entities;

namespace Game_Project.Abstract
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
