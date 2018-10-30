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
        PlayerRepository playerDetailRepository;

        public BLL_Player()
        {
            playerDetailRepository = new PlayerRepository();
        }

        public List<PlayerIndexModel>GetAllPlayers()
        {
            return playerDetailRepository.GetAllPlayersAsIndexModel();
        }

        public bool CreatePlayer(PlayerCreateModel createModel)
        {
            return playerDetailRepository.CreateNewPlayer(createModel);
        }

        public PlayerEditModel GetPlayerForEdit(int id)
        {
            return playerDetailRepository.GetPlayerEditModel(id);
        }

        public bool EditPlayer(PlayerEditModel editModel)
        {
            return playerDetailRepository.UpdatePlayerDetail(editModel);
        }
    }
}
