
namespace BlizzardApiReader.WorldOfWarcraft.Models {

    public class PetSpecies
{
    public long SpeciesId { get; set; }
    public long PetTypeId { get; set; }
    public long CreatureId { get; set; }
    public string Name { get; set; }
    public bool CanBattle { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public string Source { get; set; }
    public PetAbility[] Abilities { get; set; }
}
}