using GameDemo.Abstract;
using GameDemo.Entities;
using GameDemo.Management;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncular
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.FirstName = "merve";
            gamer1.LastName = "aydın";
            gamer1.NationalityId = "12345";
            gamer1.DateOfBirth = new DateTime(1992, 10, 10);

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 2;
            gamer2.FirstName = "ferhat";
            gamer2.LastName = "aydın";
            gamer2.NationalityId = "123456";
            gamer2.DateOfBirth = new DateTime(1985, 2, 1);

            Gamer gamer3 = new Gamer();
            gamer3.GamerId = 3;
            gamer3.FirstName = "esra";
            gamer3.LastName = "aydın";
            gamer3.NationalityId = "1234567";
            gamer3.DateOfBirth = new DateTime(1995, 1, 1);


            //Kampanyalar
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 10;
            campaign1.CampaignName = "kış ";
            campaign1.CampaignValue = "%5";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 11;
            campaign2.CampaignName = "tatil  ";
            campaign2.CampaignValue = "%10";

            Campaign campaign3 = new Campaign();
            campaign3.CampaignId = 12;
            campaign3.CampaignName = "yaz ";
            campaign3.CampaignValue = "%15";

            //Oyunlar

            Game game1 = new Game();
            game1.GameId = 5;
            game1.GameName = "tetris";
            game1.GamePrice = 100.0;

            IGamerService gamerService = new GamerManager(new GamerCheckManager());
            gamerService.Save(gamer1);
            gamerService.Update(gamer2);
            gamerService.Delete(gamer3);

            Console.WriteLine("----------------------------");

            ICampaignService campaignService = new CampaignService();
            campaignService.Add(campaign3);
            campaignService.Delete(campaign2);
            campaignService.Update(campaign1);

            Console.WriteLine("----------------------------");

            IGameSellService gameSellService = new GameManager();
            gameSellService.Sell(gamer2, game1, campaign2);
        }
    }
}
