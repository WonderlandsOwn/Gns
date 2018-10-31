using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CharacterCreateModel
    {
        public int PlayerId { get; set; }
        public string CharacterName { get; set; }
        public int CharacterRaceId { get; set; }
        public List<IdAndName> AvailableRaces { get; set; }
        public int CharacterPrimaryArchtypeId { get; set; }
        public int? CharacterSecondaryArchtypeId { get; set; }
        public List<IdAndName> AvailableArchtypes { get; set; }
    }
}
