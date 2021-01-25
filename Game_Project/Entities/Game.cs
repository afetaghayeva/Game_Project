using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;

namespace Game_Project.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
    }
}
