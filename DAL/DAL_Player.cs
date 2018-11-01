using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_Player : Repository<GnsEntities.Player>
    {

        public List<PlayerIndexRowModel> GetAllPlayersAsIndexModel()
        {
            return GetAll().Select(p =>
            new PlayerIndexRowModel()
            {
                PlayerId = p.PlayerId,
                PlayerName = p.PlayerName,
                ActiveCharacterId = p.PlayerActiveCharacterId,
                ActiveCharatcerName = p.Character.CharacterName
            }).ToList();
        }

        public PlayerModel GetPlayerEditModel(int id)
        {
            GnsEntities.Player player = GetByID(id);
            return new PlayerModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName,
                ActiveCharacterId = player.PlayerActiveCharacterId,
                ActiveCharacterName = player.Character == null ? null : player.Character.CharacterName,
                AvailableCharacters = player.Characters.Count == 0 ? null : player.Characters.Select(c => new ListPair()
                {
                    Id = c.CharacterId,
                    Name = c.CharacterName
                }).ToList()
            };
        }

        public bool UpdatePlayerDetail(PlayerModel editModel)
        {
            GnsEntities.Player player = GetByID(editModel.PlayerId);
            player.PlayerName = editModel.PlayerName;
            player.PlayerActiveCharacterId = editModel.ActiveCharacterId;
            return Update(player);
        }

        public bool CreateNewPlayer(PlayerModel createModel)
        {
            GnsEntities.Player player = new GnsEntities.Player()
            {
                PlayerName = createModel.PlayerName
            };
            return Insert(player);
        }
    }
}
