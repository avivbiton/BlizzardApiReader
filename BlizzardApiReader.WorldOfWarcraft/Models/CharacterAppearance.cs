using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterAppearance
    {
        public int FaceVariation { get; set; }
        public int SkinColor { get; set; }
        public int HairVariation { get; set; }
        public int HairColor { get; set; }
        public int FeatureVariation { get; set; }
        public bool ShowHelm { get; set; }
        public bool ShowCloak { get; set; }
        public int[] CustomDisplayOptions { get; set; }
    }
}
