using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Management
{
    public class GamerManager:IGamerService
    {
        private IGamerCheckService _gamerCheckService;
       
        
        public GamerManager(IGamerCheckService gamerCheckService)// constructor
        {
            _gamerCheckService = gamerCheckService;
        }


        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerOfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " isimli oyuncu başarıyla eklendi");
            }
            else
            {
                throw new Exception("Oyuncu gerçek değil !");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerId + " Numaralı Gamer Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerId + " Numaralı Gamer Güncellendi");
        }

        
    }
}
