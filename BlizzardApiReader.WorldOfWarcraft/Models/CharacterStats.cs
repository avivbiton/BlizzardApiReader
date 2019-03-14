using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterStats
    {
        public int Health { get; set; }
        public string PowerType { get; set; }
        public int Power { get; set; }
        public int Str { get; set; }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Sta { get; set; }
        public double SpeedRating { get; set; }
        public double SpeedRatingBonus { get; set; }
        public double Crit { get; set; }
        public int CritRating { get; set; }
        public double Haste { get; set; }
        public int HasteRating { get; set; }
        public double HasteRatingPercent { get; set; }
        public double Mastery { get; set; }
        public int MasteryRating { get; set; }
        public double Leech { get; set; }
        public double LeechRating { get; set; }
        public double LeechRatingBonus { get; set; }
        public int Versatility { get; set; }
        public double VersatilityDamageDoneBonus { get; set; }
        public double VersatilityHealingDoneBonus { get; set; }
        public double VersatilityDamageTakenBonus { get; set; }
        public double AvoidanceRating { get; set; }
        public double AvoidanceRatingBonus { get; set; }
        public double SpellPen { get; set; }
        public double SpellCrit { get; set; }
        public int SpellCritRating { get; set; }
        public double Mana5 { get; set; }
        public double Mana5Combat { get; set; }
        public int Armor { get; set; }
        public double Dodge { get; set; }
        public int DodgeRating { get; set; }
        public double Parry { get; set; }
        public int ParryRating { get; set; }
        public double Block { get; set; }
        public int BlockRating { get; set; }
        public double MainHandDmgMin { get; set; }
        public double MainHandDmgMax { get; set; }
        public double MainHandSpeed { get; set; }
        public double MainHandDps { get; set; }
        public double OffHandDmgMin { get; set; }
        public double OffHandDmgMax { get; set; }
        public double OffHandSpeed { get; set; }
        public double OffHandDps { get; set; }
        public double RangedDmgMin { get; set; }
        public double RangedDmgMax { get; set; }
        public double RangedSpeed { get; set; }
        public double RangedDps { get; set; }
    }
}
