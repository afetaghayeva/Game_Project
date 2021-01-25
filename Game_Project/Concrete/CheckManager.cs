using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Abstract;

namespace Game_Project.Concrete
{
    class CheckManager:ICheckService
    {
        public bool IsCheckPlayer()
        {
            return true ;
        }
    }
}
