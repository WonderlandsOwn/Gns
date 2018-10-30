using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public class CharacterIndexRowModel
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public int CharacterActiveRaceId { get; set; }
        public string CharacterActiveRaceName { get; set; }
        public int CharacterActivePrimaryArchtypeId { get; set; }
        public string CharacterActivePrimaryArchtypeName { get; set; }
        public int? CharacterActiveSecondaryArchtypeId { get; set; }
        public string CharacterActiveSecondaryArchtypeName { get; set; }
    }
}
