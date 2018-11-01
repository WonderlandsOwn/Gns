using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PlayerIndexRowModel
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? ActiveCharacterId { get; set; }
        public string ActiveCharatcerName { get; set; }
    }
}
