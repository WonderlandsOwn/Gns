using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RaceCreateModel
    {
        public string RaceName { get; set; }
        public string RaceShortDescription { get; set; }
        public string RaceDescription { get; set; }
        public int BonusHealth { get; set; }
        public int BonusStamina { get; set; }
        public int BonusStrength { get; set; }
        public int BonusAgility { get; set; }
        public int BonusIntellect { get; set; }
        public int BonusFortitude { get; set; }
        public int BonusEndurance { get; set; }
        public int BonusConstitution { get; set; }
    }
}
