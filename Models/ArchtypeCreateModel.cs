using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ArchtypeCreateModel
    {
        public string ArchtypeName { get; set; }
        public string ArchtypeShortDescription { get; set; }
        public string ArchtypeDescription { get; set; }
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
