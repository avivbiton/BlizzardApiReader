using BlizzardApiReader.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Enums
{
    public enum Region
    {
        EU,
        KR,
        SEA,
        TW,
        US,
        [EnumName("EU")]
        Europe,
        [EnumName("KR")]
        Korea,
        [EnumName("SEA")]
        SoutheastAsia,
        [EnumName("TW")]
        Taiwan,
        [EnumName("US")]
        UnitedStates,
    }
}
