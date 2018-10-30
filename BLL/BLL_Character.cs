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
        CharacterRepository characterRepository;

        public BLL_Character()
        {
            characterRepository = new CharacterRepository();
        }

        public List<CharacterIndexRowModel> GetCharacterIndex(int playerId)
        {
            return new PlayerRepository().GetPlayerCharacterIndex(playerId);
        }
    }
}
