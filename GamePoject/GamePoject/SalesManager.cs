using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + ":"+ game.GameName + " oyununu satın aldı.");
            
        }
        public void CampaignSales(Game game,Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + ":"+ campaign.CampaignName + " ile " + game.GameName + " oyununu satın aldı.");
        }
    }
}
