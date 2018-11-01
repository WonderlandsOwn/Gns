using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CharacterDetailModel
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string CharacterPrimaryArchtypeName { get; set; }
        public string CharacterSecondaryArchtypeName { get; set; }
        public string CharacterTertiaryArchtypeName { get; set; }
        public string CharacterBaseSpellName { get; set; }
        public string CharacterPrimarySpellName { get; set; }
        public string CharacterSecondarySpellName { get; set; }
        public string CharacterTertiarySpellName { get; set; }
        public BonusModel CharacterTotalBonus { get; set; }
    }
}
