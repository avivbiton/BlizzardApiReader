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
