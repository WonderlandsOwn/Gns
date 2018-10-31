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

        public List<PlayerIndexModel> GetAllPlayersAsIndexModel()
        {
            return GetAll().Select(p =>
            new PlayerIndexModel()
            {
                PlayerId = p.PlayerId,
                PlayerName = p.PlayerName,
                ActiveCharacterId = p.PlayerActiveCharacterId,
                ActiveCharatcerName = p.Character.CharacterName
            }).ToList();
        }

        public PlayerEditModel GetPlayerEditModel(int id)
        {
            GnsEntities.Player player = GetByID(id);
            return new PlayerEditModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName,
                ActiveCharacterId = player.PlayerActiveCharacterId,
                ActiveCharacterName = player.Character == null ? null : player.Character.CharacterName,
                AvailableCharacters = player.Characters.Count == 0 ? null : player.Characters.Select(c => new IdAndName()
                {
                    Id = c.CharacterId,
                    Name = c.CharacterName
                }).ToList()
            };
        }

        public bool UpdatePlayerDetail(PlayerEditModel editModel)
        {
            GnsEntities.Player player = GetByID(editModel.PlayerId);

            player.PlayerName = editModel.PlayerName;
            player.PlayerActiveCharacterId = editModel.ActiveCharacterId;
            return Update(player);
        }

        public bool CreateNewPlayer(PlayerCreateModel createModel)
        {
            GnsEntities.Player player = new GnsEntities.Player()
            {
                PlayerName = createModel.PlayerName
            };
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
