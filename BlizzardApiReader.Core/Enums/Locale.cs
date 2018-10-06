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
    }
}
