namespace BlizzardApiReader.WorldOfWarcraft.Models {

public class PetAbility
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public int Cooldown { get; set; }
    public int Rounds { get; set; }
    public int PetTypeId { get; set; }
    public bool IsPassive { get; set; }
    public bool HideHints { get; set; }

    //From Species
    public int Slot { get; set; }
    public int Order { get; set; }
    public int RequiredLevel { get; set; }
    
}
}