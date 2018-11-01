using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //TODO:Add DataAnnotations
    public class ArchtypeCreateModel
    {
        public string ArchtypeName { get; set; }
        public string ArchtypeShortDescription { get; set; }
        public string ArchtypeLongDescription { get; set; }
        public int ArchtypeRankId { get; set; }
        public List<ListPair> AvailableRanks { get; set; }
        public BonusModel ArchtypeBonus { get; set; }
    }
}
