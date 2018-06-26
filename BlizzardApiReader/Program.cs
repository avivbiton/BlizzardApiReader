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
            ApiReader.ReadKeyFromFile(Directory.GetCurrentDirectory() + "/BlizzardApiReader/" + "apikey.txt");
            RunAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }

        public static async Task RunAsync()
        {
            Console.WriteLine("insert battle tag");
            string tag = Console.ReadLine();

            BattleAccount acc = await DiabloApi.GetApiAccount(tag);
            foreach (var hero in acc.heroes)
            {
                Console.WriteLine($"class name: {hero.className}, id: {hero.id}");
            }

            foreach (var killName in acc.kills.Keys)
            {
                Console.WriteLine($"Killed {acc.kills[killName]} {killName}");
            }

            StoryAct act1 = await DiabloApi.GetAct(1);

            Console.WriteLine($"act 1 name: {act1.name}");

            var acts = await DiabloApi.GetActIndex();

            Console.WriteLine("total acts: " + acts.Count);

        }


    }
}
