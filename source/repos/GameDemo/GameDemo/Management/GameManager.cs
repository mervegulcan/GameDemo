using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Management
{
    public class GameManager : IGameSellService
    {

        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " isimli oyunu " + game.GamePrice + " fiyata satıyor. ");
            Console.WriteLine(campaign.CampaignName + "kampanyasından yararlanabilirsiniz");
        }
    }
}
