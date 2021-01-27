using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckGamerOfRealGamer(Gamer gamer);
    }
}
