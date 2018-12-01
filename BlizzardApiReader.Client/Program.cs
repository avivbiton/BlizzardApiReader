using BlizzardApiReader.Core;
using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Diablo;
using BlizzardApiReader.Diablo.Models;

using System;

namespace BlizzardApiReader.Client
{
    class Program
    {
        private static readonly string clientId = "<Your CLIENT ID from develop.battle.net>";
        private static readonly string secret = "<Your SECRET from develop.battle.net>";

        static void Main(string[] args)
        {
            ApiConfiguration.CreateDefault()
                .SetClientId(clientId)
                .SetClientSecret(secret)
                .SetLocale(Locale.BritishEnglish)
                .SetRegion(Region.Europe)
                .DeclareAsDefault();

            DiabloApi api = new DiabloApi();
            StoryAct act1 =  api.GetActAsync(1).Result;
            Console.WriteLine($"act 1 name: {act1.Name}");
            Console.ReadLine();
        }
    }
}
