using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Player
    {
        DAL_Player PlayerRepository;

        public BLL_Player()
        {
            PlayerRepository = new DAL_Player();
        }

        public List<PlayerIndexRowModel>GetCompletePlayerIndex()
        {
            return PlayerRepository.GetAllPlayersAsIndexModel();
        }

        public bool CreatePlayer(PlayerModel createModel)
        {
            return PlayerRepository.CreateNewPlayer(createModel);
        }

        public PlayerModel GetPlayerForEdit(int id)
        {
            return PlayerRepository.GetPlayerEditModel(id);
        }

        public bool EditPlayer(PlayerModel editModel)
        {
            return PlayerRepository.UpdatePlayerDetail(editModel);
        }
    }
}
