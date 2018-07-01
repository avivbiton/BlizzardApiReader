using BlizzardApiReader.Diablo.Models;
using BlizzardApiReader.Diablo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlizzardApiReader
{
    /// <summary>
    /// currently used for testing 
    /// </summary>
    class Program
    {


        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }

        public static async Task RunAsync()
        {
            Console.WriteLine("insert battle tag");
            string tag = Console.ReadLine();

            string key = ReadKeyFromFile(Directory.GetCurrentDirectory() + "/apikey.txt");

            ApiReader reader = new ApiReader(new ApiConfiguration()
            {
                ApiRegion = Region.EU,
                locale = Locale.en_GB,
                Key = key
            });

            DiabloApi api = new DiabloApi(reader);
         

            BattleAccount acc = await api.GetApiAccount(tag);
            foreach (var hero in acc.heroes)
            {
                Console.WriteLine($"class name: {hero.className}, id: {hero.id}");
            }

            foreach (var killName in acc.kills.Keys)
            {
                Console.WriteLine($"Killed {acc.kills[killName]} {killName}");
            }

            StoryAct act1 = await api.GetAct(1);

            Console.WriteLine($"act 1 name: {act1.name}");

            var acts = await api.GetActIndex();

            Console.WriteLine("total acts: " + acts.Count);

            Console.WriteLine("==================================================================");
            DetailedArtisan artisan = await api.GetArtisan("blacksmith");
            Console.WriteLine($"artisan tiers: {artisan.tiers.Count}");
            int totalRecipes = 0;
            foreach(var tier in artisan.tiers)
            {
                totalRecipes += tier.trainedRecipes.Count;
            }
            Console.WriteLine($"there are a total of {totalRecipes} crafting recipes in game");

            // get specific recipe

            DetailedArtisan.ArtisanRecipe recipe = await api.GetArtisanRecipe("blacksmith", "apprentice-flamberge");
            Console.WriteLine($"this recipe produce: {recipe.itemProduced.name}");


        }


        public static string ReadKeyFromFile(string path)
        {
            if (File.Exists(path))
            {

                string key = File.ReadAllText(path);
                return key;

            }
            else
            {
                throw new FileNotFoundException();
            }
        }

    }
}
