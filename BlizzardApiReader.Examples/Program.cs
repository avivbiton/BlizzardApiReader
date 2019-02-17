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
            //Use your info here
            string clientId = "725104f779ad4300a44222e3a5c06093";
            string secret = "fxWYI9Xa6SlSZVySQONjCqLxnO8Bf5OI";
            int sc2ID = 8323934;
            string bt = "oisinmcl#2126";

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
                #region tests
                //Using Diablo API
                //Get first Act information
                StoryAct act1 = await d3api.GetActAsync(1);
                Console.WriteLine($"act 1 name: {act1.Name}");

                //Using World of Warcraft API
                //Get list of bosses
                List<Boss> bosses = wowApi.GetBossesAsync().Result;
                foreach (Boss boss in bosses)
                {
                    Console.WriteLine($"Encounter: {boss.Name}, Description: { boss.Description}");
                }

                //Using Starcraft 2 API
                Profile profile = await sc2Api.GetProfileAsync(2, 1, sc2ID);
                Console.WriteLine($"Profile ID: {profile.Summary.ID}, RealmID: {profile.Summary.RealmID}, DisplayName: {profile.Summary.DisplayName}, Portrait: {profile.Summary.Portrait}, " +
                                    $"DecalTerran: {profile.Summary.DecalTerran}, DecalProtoss: {profile.Summary.DecalProtoss}, DecalZerg: {profile.Summary.DecalZerg}, " +
                                    $"TotalSwarmLevel: {profile.Summary.TotalSwarmLevel}, TotalAchievementPoints: {profile.Summary.TotalAchievementPoints}");

                foreach (var snap in profile.Snapshot.SeasonSnapshot)
                {
                    Console.WriteLine($"Name: {snap.Key}");
                }

                Static s = await sc2Api.GetStaticAsync(2);
                foreach (Starcraft2.Models.Achievement a in s.Achievements)
                {
                    Console.WriteLine($"CategoryId: {a.CategoryId}, Id: {a.ID}, Points: {a.Points}");
                }

                MetaData metaData = await sc2Api.GetMetaDataAsync(2, 1, sc2ID);
                Console.WriteLine($"Name: {metaData.Name}, ProfileUrl: {metaData.ProfileUrl}, AvatarUrl: {metaData.AvatarUrl},ProfileId: {metaData.ProfileId}, " +
                                     $"RegionId: {metaData.RegionId}, RealmId: {metaData.RealmId}");


                List<GrandmasterLeaderboard> GMLeaderboard = await sc2Api.GetGrandmasterLeaderboardAsync(2);
                foreach (GrandmasterLeaderboard GM in GMLeaderboard)
                {
                    Console.WriteLine($"Members Count: {GM.TeamMembers.Count}, Previous Rank: {GM.PreviousRank}, Points: {GM.Points}, " +
                                        $"Wins: {GM.Wins}, Losses: {GM.Losses}, MMR: {GM.MMR}, JoinTimestamp: {GM.JoinTimestamp}");
                }

                #endregion



            }).GetAwaiter().GetResult();


            Console.Read();
        }
    }
}
