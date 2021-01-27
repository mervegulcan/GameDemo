using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameSellService
    {
        void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}
