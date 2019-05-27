using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Guild
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public int AchievementPoints { get; set; }
        public GuildEmblem Emblem { get; set; }

        public int Level { get; set; }
        public int Side { get; set; }

        [JsonConverter(typeof(GuildMembersConverter))]
        public GuildMember[] Members { get; set; }

        //Field=achievements
        public Achievements Achievements { get; set; }

        //Field=news
        public GuildNewsItem[] News { get; set; }

        //Field=challenge
        public Challenge[] Challenge { get; set; }
    }

    class GuildMembersConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(GuildMember[]));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<GuildMember[]>();
            }
            
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
