using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Character
    {
        public string Name { get; set; }

        public string Realm { get; set; }

        public string BattleGroup { get; set; }

        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchivementPoints { get; set; }
        public string Thumbnail { get; set; }

        public Spec Spec { get; set; }
                
        //TODO: Review format, sometimes comes with a value of 0, sometimes with >0
        //TODO: Look for which format is used and how to deal with the 0 values.
        public string LastModified { get; set; }

        // Fields comming from profile

        public string CalcClass { get; set; }

        public int Faction { get; set; }

        public int TotalHonorableKills { get; set; }

        //Extended Information that can be requested optionaly

        //Field=achievements
        public Achievements Achievements { get; set; }

        //Field=appearance
        public CharacterAppearance Appearance { get; set; }

        //Field=feed
        public CharacterFeedItem[] Feed { get; set; }

        //Field=guild
        [JsonProperty("guild")]
        [JsonConverter(typeof(GuildConverter))]
        public CharacterGuild Guild { get; set; }

        /* TODO: Review how can we get the guild when it comes as a name (string) instead as an object and put in other property
        [JsonProperty("guild")]        
        public string Guild { get; set; }        

        public string GuildRealm { get; set; }
        */
        
        //Field=hunterPets
        public HunterPet[] HunterPets { get; set; }

        //Field=items
        public CharacterItems Items { get; set; }
        
        //Field=mounts
        public CharacterMounts Mounts { get; set; }
        
        //Field=pets
        public CharacterPets Pets { get; set; }

        //Field=petSlots
        public CharacterPetSlot[] PetSlots { get; set; }

        //Field=professions
        public CharacterProfessions Professions { get; set; }

        //Field=progression
        public CharacterProgression Progression { get; set; }

        //Field=pvp
        public CharacterPvp Pvp { get; set; }

        //Field=quests
        public int[] Quests { get; set; }

        //Field=reputation
        public CharacterReputation[] Reputation { get; set; }

        //Field=statistics
        public CharacterSubCategories Statistics { get; set; }

        //Field=stats
        public CharacterStats Stats { get; set; }

        //Field=talents
        public CharacterTalent[] Talents { get; set; }

        //Field=titles
        public CharacterTitle[] Titles { get; set; }
    }

    class GuildConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(CharacterGuild));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<CharacterGuild>();
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
