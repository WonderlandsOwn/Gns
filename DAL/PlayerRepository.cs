using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class PlayerRepository : Repository<GnsEntities.Player>
    {

        public List<PlayerIndexModel> GetAllPlayersAsIndexModel()
        {
            return GetAll().Select(p =>
            new PlayerIndexModel()
            {
                PlayerId = p.PlayerId,
                PlayerName = p.PlayerName,
                ActiveCharacterId = p.PlayerDetail.ActiveCharacterId,
                ActiveCharatcerName = p.PlayerDetail.Character.CharacterName
            }).ToList();
        }

        public PlayerEditModel GetPlayerEditModel(int id)
        {
            GnsEntities.Player player = GetByID(id);
            PlayerEditModel model = new PlayerEditModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName,
                ActiveCharacterId = player.PlayerDetail.ActiveCharacterId,
                ActiveCharacterName = player.PlayerDetail.ActiveCharacterId.Equals(null) ? null : player.PlayerDetail.Character.CharacterName,
                AvailableCharacters = player.PlayerDetail.Player.Characters.Count.Equals(0) ? null : player.Characters.Select(c => new BasicListModel()
                {
                    Id = c.CharacterId,
                    Name = c.CharacterName
                }).ToList()
            };

            return model;
        }

        public bool UpdatePlayerDetail(PlayerEditModel editModel)
        {
            GnsEntities.Player player = GetByID(editModel.PlayerId);

            player.PlayerName = editModel.PlayerName;
            player.PlayerDetail.ActiveCharacterId = editModel.ActiveCharacterId;
            return Update(player);
        }

        public bool CreateNewPlayer(PlayerCreateModel createModel)
        {
            GnsEntities.Player player = new GnsEntities.Player();
            player.PlayerName = createModel.PlayerName;
            return Insert(player);
        }

        public List<CharacterIndexRowModel> GetPlayerCharacterIndex(int id)
        {
            return new Repository<GnsEntities.Player>().GetByID(id).Characters.Select(c => new CharacterIndexRowModel()
            {
                CharacterId = c.CharacterId,
                CharacterName = c.CharacterName,
                CharacterActivePrimaryArchtypeId = c.CharacterPrimaryArchtypeId,
                CharacterActivePrimaryArchtypeName = c.CharacterPrimaryArchtype.ArchtypeName,
                CharacterActiveSecondaryArchtypeId = c.CharacterSecondaryArchtypeId,
                CharacterActiveSecondaryArchtypeName = c.CharacterSecondaryArchtype.ArchtypeName,
                CharacterActiveRaceId = c.CharacterRaceId,
                CharacterActiveRaceName = c.Race.RaceName
            }).ToList();

        }
    }
}
