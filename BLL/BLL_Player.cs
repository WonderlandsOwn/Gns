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

        public List<PlayerIndexModel>GetCompletePlayerIndex()
        {
            return PlayerRepository.GetAllPlayersAsIndexModel();
        }

        public bool CreatePlayer(PlayerCreateModel createModel)
        {
            return PlayerRepository.CreateNewPlayer(createModel);
        }

        public PlayerEditModel GetPlayerForEdit(int id)
        {
            return PlayerRepository.GetPlayerEditModel(id);
        }

        public bool EditPlayer(PlayerEditModel editModel)
        {
            return PlayerRepository.UpdatePlayerDetail(editModel);
        }
    }
}
