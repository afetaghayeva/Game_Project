using System;
using Game_Project.Concrete;
using Game_Project.Entities;

namespace Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Id = 1,
                FirstName = "Afet",
                LastName = "Agayeva",
                DateTime = new DateTime(2003, 1, 6)
            };
            Game game1 = new Game
            {
                Id = 1,
                GameName = "Pubg",
                Price = 100
            };
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = "Discount campaign",
                Percent = 10
            };
            SellingManager sellingManager = new SellingManager();
            sellingManager.Buy(player1,game1,campaign1);

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);

            AuthManager authManager = new AuthManager(new CheckManager());
            authManager.Register();

        }
    }
}
