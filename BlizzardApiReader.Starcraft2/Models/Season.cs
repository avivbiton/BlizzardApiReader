using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Season
    {
        public int SeasonID { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }

    }
}
