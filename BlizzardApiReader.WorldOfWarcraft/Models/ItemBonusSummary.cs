
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
public class ItemBonusSummary
{
    public object[] DefaultBonusLists { get; set; }
    public object[] ChanceBonusLists { get; set; }
    public object[] BonusChances { get; set; }
}
}