using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Kampanyalı oyun eklendi.İyi Eğlenceler."+ " İndirim Oranı: %"+ campaign.DiscountRate+ '\n');
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ ": Kampanya süresi dolduğu için oyun silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ ": Müjde! Kampanya güncellendi." + "İndirim Oranı: %"+  campaign.DiscountRate+'\n');
        }
    }
}
