using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Character
    {
        DAL_Character characterRepository;

        public BLL_Character()
        {
            characterRepository = new DAL_Character();
        }

        public List<CharacterIndexRowModel> GetCharacterIndex(int playerId)
        {
            return new DAL_Player().GetPlayerCharacterIndex(playerId);
        }
    }
}
