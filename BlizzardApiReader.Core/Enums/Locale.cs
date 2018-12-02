using BlizzardApiReader.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Enums
{
    public enum Locale
    {
        [EnumValue("en_GB")]
        BritishEnglish,
        [EnumValue("ko_KR")]
        Korean,
        [EnumValue("zh_TW")]
        TraditionalChinese,
        [EnumValue("en_US")]
        AmericanEnglish,
        [EnumValue("es_MX")]
        MexicanSpanish,
        [EnumValue("pt_BR")]
        BrazilianPortuguese,
        [EnumValue("de_de")]
        German,
        [EnumValue("es_ES")]
        SpainSpanish,
        [EnumValue("fr_FR")]
        French,
        [EnumValue("it_IT")]
        Italian,
        [EnumValue("pt_PT")]
        PortugalPortuguese,
        [EnumValue("ru_RU")]
        Russian,
        [EnumValue("zh_CN")]
        SimplifiedChinese,

    }
}
