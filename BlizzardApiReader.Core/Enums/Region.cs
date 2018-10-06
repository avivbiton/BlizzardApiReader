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
        [EnumValue("EU")]
        Europe,
        [EnumValue("KR")]
        Korea,
        [EnumValue("SEA")]
        SoutheastAsia,
        [EnumValue("TW")]
        Taiwan,
        [EnumValue("US")]
        UnitedStates,
    }
}
