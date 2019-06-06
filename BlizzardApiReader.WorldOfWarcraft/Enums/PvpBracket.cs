using BlizzardApiReader.Core.Attributes;

namespace BlizzardApiReader.WorldOfWarcraft.Enums
{
    public enum PvpBracket
    {
        [EnumValue("2v2")]
        Bracket2v2,
        [EnumValue("3v3")]
        Bracket3v3,
        [EnumValue("5v5")]
        Bracket5v5,
        [EnumValue("rbg")]
        BracketRBG
    }
}
