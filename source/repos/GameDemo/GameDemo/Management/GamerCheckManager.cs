using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Management
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckGamerOfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
