using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;

namespace Game_Project.Concrete
{
    class AuthManager:IAuthService
    {
        private readonly ICheckService _checkService;

        public AuthManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void Register()
        {
            if (_checkService.IsCheckPlayer())
            {
                Console.WriteLine("Player is registered");
            }
            else
            {
                Console.WriteLine("Player cannot registered");
            }
            
        }

        public void Login()
        {
            Console.WriteLine("Player is login");
        }
    }
}
