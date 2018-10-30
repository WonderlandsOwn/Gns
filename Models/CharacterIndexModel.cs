using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CharacterIndexModel
    {
        public int PlayerId { get; set; }
        public List<CharacterIndexRowModel> CharacterIndex { get; set; }
    }
}
