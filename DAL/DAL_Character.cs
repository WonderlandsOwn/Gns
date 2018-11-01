using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Parsers;
namespace DAL
{
    public class DAL_Character : Repository<GnsEntities.Character>
    {

        public List<CharacterIndexRowModel> GetPlayerCharacterIndex(int id)
        {
            return GetAll()
                .Where(c => c.CharacterPlayerId == id)
                .Select(c => new CharacterIndexRowModel()
                {
                    CharacterId = c.CharacterId,
                    CharacterName = c.CharacterName,

                    CharacterActivePrimaryArchtypeId = c.CharacterPrimaryArchtypeId,
                    CharacterActivePrimaryArchtypeName = c.CharacterPrimaryArchtype.ArchtypeName,

                    CharacterActiveSecondaryArchtypeId = c.CharacterSecondaryArchtypeId,
                    CharacterActiveSecondaryArchtypeName = c.CharacterSecondaryArchtype.ArchtypeName,

                    CharacterActiveTertiaryArchtypeId = c.CharacterTertiaryArchtypeId,
                    CharacterActiveTertiaryArchtypeName = c.CharacterTertiaryArchtypeId == null ? null : c.CharacterTertiaryArchtype.ArchtypeName

                }).ToList();
        }

        public List<BonusModel> GetArchTypeBonuses(int id)
        {
            List<BonusModel> returnList = new List<BonusModel>();
            GnsEntities.Character character = GetByID(id);
            returnList.Add(
                BonusModelParser.GetBonusModel(character.CharacterPrimaryArchtype.ArchtypeBonu)
                );
            returnList.Add(
                BonusModelParser.GetBonusModel(character.CharacterSecondaryArchtype.ArchtypeBonu)
                );

            if(character.CharacterTertiaryArchtypeId != null)
            {
                returnList.Add(
                BonusModelParser.GetBonusModel(character.CharacterTertiaryArchtype.ArchtypeBonu)
                );
            }
            return returnList;
        }

        public bool CreateNewCharacter(CharacterCreateModel createModel)
        {
            GnsEntities.Character character = new GnsEntities.Character();

            character.CharacterPlayerId = createModel.PlayerId;
            character.CharacterName = createModel.CharacterName;
            character.CharacterPrimaryArchtypeId = createModel.CharacterPrimaryArchtypeId;
            character.CharacterSecondaryArchtypeId = createModel.CharacterSecondaryArchtypeId;
            character.CharacterTertiaryArchtypeId = createModel.CharacterTertiaryArchtypeId;
            return Insert(character);
        }

        public CharacterDetailModel GetCharacterDetail(int id)
        {
            GnsEntities.Character character = GetByID(id);
            return new CharacterDetailModel()
            {
                CharacterId = character.CharacterId,
                CharacterName = character.CharacterName,
                CharacterPrimaryArchtypeName = character.CharacterPrimaryArchtype.ArchtypeName,
                CharacterSecondaryArchtypeName = character.CharacterSecondaryArchtype.ArchtypeName,
                CharacterTertiaryArchtypeName = character.CharacterTertiaryArchtypeId == null ? null : character.CharacterTertiaryArchtype.ArchtypeName
            };
        }
        public bool UpdateCharacter(CharacterCreateModel editModel)
        {
            throw new NotImplementedException();
        }
    }
}
