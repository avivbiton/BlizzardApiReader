using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{

public class ItemSet
{
    public long Id { get; set; }
    public string Name { get; set; }
    public SetBonus[] SetBonuses { get; set; }
    public long[] Items { get; set; }
}

public class SetBonus
{
    public string Description { get; set; }
    public long Threshold { get; set; }
}
}