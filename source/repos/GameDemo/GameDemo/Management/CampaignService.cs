using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Management
{
    public class CampaignService : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya eklendi" );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya güncellendi");
        }
    }
}
