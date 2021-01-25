using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;

namespace Game_Project.Entities
{
    class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
