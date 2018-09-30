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
        en_GB,
        ko_KR,
        zh_TW,
        en_US,
        [EnumName("en_GB")]
        BritishEnglish,
        [EnumName("ko_KR")]
        Korean,
        [EnumName("zh_TW")]
        TraditionalChinese,
        [EnumName("en_US")]
        AmericanEnglish,
    }
}
