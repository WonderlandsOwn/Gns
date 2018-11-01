using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //TODO:Add DataAnnotations
    public class CharacterCreateModel
    {
        public int PlayerId { get; set; }
        public string CharacterName { get; set; }       
        public int CharacterPrimaryArchtypeId { get; set; }
        public List<ListPair> AvailablePrimaryArchtypes { get; set; }
        public int CharacterSecondaryArchtypeId { get; set; }
        public List<ListPair> AvailableSecondaryArchtypes { get; set; }
        public int? CharacterTertiaryArchtypeId { get; set; }
        public List<ListPair> AvailableTertiaryArchtypes { get; set; }
    }
}
