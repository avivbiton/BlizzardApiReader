using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlizzardApiReader.Core;
using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Diablo;
using BlizzardApiReader.Diablo.Models;
using BlizzardApiReader.WorldOfWarcraft;
using BlizzardApiReader.WorldOfWarcraft.Models;
using BlizzardApiReader.Starcraft2;
using BlizzardApiReader.Starcraft2.Models;

namespace BlizzardApiReader.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use you info here
            string clientId = "725104f779ad4300a44222e3a5c06093";
            string secret = "FXxQgvm5PPcRXU6AR8S0hc84f5JpHSJp";

            ApiConfiguration.Create()
                              .SetClientId(clientId)
                              .SetClientSecret(secret)
                              .SetRegion(Region.Europe)
                              .SetLocale(Locale.BritishEnglish)
                              .DeclareAsDefault();

            //For Diablo API
            var d3api = new DiabloApi();

            //For World of Warcraft API
            var wowApi = new WorldOfWarcraftApi();

            //For Starcraft 2 API
            var sc2Api = new Starcraft2Api();

            Task.Run(async () =>
            {

                //Using Diablo API
                //Get first Act information
                StoryAct act1 = await d3api.GetActAsync(1);
                Console.WriteLine($"act 1 name: {act1.Name}");

                //Using World of Warcraft API
                List<Boss> bosses = wowApi.GetBossesAsync().Result;
                foreach (Boss boss in bosses)
                {
                    Console.WriteLine($"Encounter: {boss.Name} Description: {boss.Description}");
                }

                //Using Starcraft 2 API
                League league = await sc2Api.GetLeagueAsync("37", "201", "0", "6");
                Console.WriteLine($"League ID: {league.Key.league_id} Season ID: {league.Key.season_id}");

                Account account = await sc2Api.GetAccountAsync("oisinmcl#2126");
                Console.WriteLine($"League ID: {league.Key.league_id} Season ID: {league.Key.season_id}");


            }).GetAwaiter().GetResult();


            Console.Read();
        }
    }
}
