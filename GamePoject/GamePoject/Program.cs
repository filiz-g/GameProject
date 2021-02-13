using System;

namespace GamePoject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager1.Add(new Gamer
            {
                Id = 1,
                FirstName = "Filiz",
                LastName = "Gül",
                BirthYear = 1993,
                IdentityNumber = 109876
        
            });

            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id=4, FirstName="Gamze", LastName="Gül", BirthYear=1992,IdentityNumber=36911};

            Game game1 = new Game() { Id = 2, GameName = "Word Game", GamePrice = 100};
            Game game2 = new Game() { Id=3, GameName="Puzzle", GamePrice= 150};

            Campaign campaign1 = new Campaign() { CampaignName = "Yeni Yıl Kampanyası", DiscountRate = 3, CampaignId=1};
            Campaign campaign2 = new Campaign() { CampaignName = "Sömestir", DiscountRate =5,CampaignId=2};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
           

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer2);
            salesManager.CampaignSales(game2, gamer2, campaign1);
           

            Console.ReadLine();
        }

    }
}
