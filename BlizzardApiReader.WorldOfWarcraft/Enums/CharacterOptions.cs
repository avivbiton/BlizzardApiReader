using System;
using System.Collections.Generic;

namespace BlizzardApiReader.WorldOfWarcraft.Enums
{

public enum CharacterOptions
    {
        None = 0,
        Guild = 1,
        Stats = 2,
        Talents = 4,
        Items = 8,
        Reputation = 16,
        Titles = 32,
        Professions = 64,
        Appearance = 128,
        PetSlots = 256,
        Mounts = 512,
        Pets = 1024,
        Achievements = 2048,
        Progression = 4096,
        Feed = 8192,
        PvP = 16384,
        Quests = 32768,
        HunterPets = 65536,
        AllOptions = Guild | Stats | Talents |
                    Items | Reputation | Titles |
                    Professions | Appearance | PetSlots |
                    Mounts | Pets | Achievements | Progression |
                    Feed | PvP | Quests | HunterPets
    }
public class CharacterFields
    {
        //http://stackoverflow.com/questions/1285986/flags-enum-bitwise-operations-vs-string-of-bits
        //http://www.codeproject.com/Articles/396851/Ending-the-Great-Debate-on-Enum-Flags
        public static string BuildOptionalFields(CharacterOptions characterOptions)
        {
            var fields = "&fields=";
            var fieldList = new List<object>();

            if ((characterOptions & CharacterOptions.Guild) == CharacterOptions.Guild)
            {
                fieldList.Add("guild");
            }

            if ((characterOptions & CharacterOptions.Stats) == CharacterOptions.Stats)
            {
                fieldList.Add("stats");
            }

            if ((characterOptions & CharacterOptions.Talents) == CharacterOptions.Talents)
            {
                fieldList.Add("talents");
            }

            if ((characterOptions & CharacterOptions.Items) == CharacterOptions.Items)
            {
                fieldList.Add("items");
            }

            if ((characterOptions & CharacterOptions.Reputation) == CharacterOptions.Reputation)
            {
                fieldList.Add("reputation");
            }

            if ((characterOptions & CharacterOptions.Titles) == CharacterOptions.Titles)
            {
                fieldList.Add("titles");
            }

            if ((characterOptions & CharacterOptions.Professions) == CharacterOptions.Professions)
            {
                fieldList.Add("professions");
            }

            if ((characterOptions & CharacterOptions.Appearance) == CharacterOptions.Appearance)
            {
                fieldList.Add("appearance");
            }

            if ((characterOptions & CharacterOptions.PetSlots) == CharacterOptions.PetSlots)
            {
                fieldList.Add("petSlots");
            }

            if ((characterOptions & CharacterOptions.Mounts) == CharacterOptions.Mounts)
            {
                fieldList.Add("mounts");
            }

            if ((characterOptions & CharacterOptions.Pets) == CharacterOptions.Pets)
            {
                fieldList.Add("pets");
            }

            if ((characterOptions & CharacterOptions.Achievements) == CharacterOptions.Achievements)
            {
                fieldList.Add("achievements");
            }

            if ((characterOptions & CharacterOptions.Progression) == CharacterOptions.Progression)
            {
                fieldList.Add("progression");
            }

            if ((characterOptions & CharacterOptions.Feed) == CharacterOptions.Feed)
            {
                fieldList.Add("feed");
            }

            if ((characterOptions & CharacterOptions.PvP) == CharacterOptions.PvP)
            {
                fieldList.Add("pvp");
            }

            if ((characterOptions & CharacterOptions.Quests) == CharacterOptions.Quests)
            {
                fieldList.Add("quests");
            }

            if ((characterOptions & CharacterOptions.HunterPets) == CharacterOptions.HunterPets)
            {
                fieldList.Add("hunterPets");
            }

            if (fieldList.Count == 0)
            {
                return string.Empty;
            }

            fields += string.Join(",", fieldList);
            return fields;            
        }
    }
}