using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ArchtypeDetailModel
    {
        public string ArchtypeRankName { get; set; }
        public string ArchtypeName { get; set; }        
        public string ArchtypeShortDescription { get; set; }
        public string ArchtypeDescription { get; set; }
        public BonusModel ArchtypeBonus { get; set; }
        public List<ListPair>ArchTypeSpells { get; set; }
    }
}
