using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PlayerEditModel
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string ActiveCharacterName { get; set; }
        public int? ActiveCharacterId { get; set; }
        public List<BasicListModel>AvailableCharacters { get; set; }
    }
}
