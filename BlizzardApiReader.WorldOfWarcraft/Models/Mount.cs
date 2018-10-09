using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Mount
    {
        public string Name { get; set; }
        public int SpellId { get; set; }
        public int CreatureId { get; set; }
        public int ItemId { get; set; }
        public int QualityId { get; set; }
        public string Icon { get; set; }
        public bool IsGround { get; set; }
        public bool IsFlying { get; set; }
        public bool IsAquatic { get; set; }
        public bool IsJumping { get; set; }
    }

    public class MountApiModel
    {
        public IEnumerable<Mount> Mounts { get; set; }
    }
}
