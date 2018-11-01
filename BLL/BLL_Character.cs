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
            return characterRepository.GetPlayerCharacterIndex(playerId);
        }

        public bool CreateCharacter(CharacterCreateModel createModel)
        {
            return characterRepository.CreateNewCharacter(createModel);
        }

        public CharacterDetailModel GetCharacterDetails(int id)
        {
            CharacterDetailModel detailModel = characterRepository.GetCharacterDetail(id);
            detailModel.CharacterTotalBonus = GetCharacterTotalBonus(id);
            //todo: get spell list
            return detailModel;
        }

        public BonusModel GetCharacterTotalBonus(int id)
        {
            List<BonusModel> bonusList = characterRepository.GetArchTypeBonuses(id);

            BonusModel bonusModel = new BonusModel();

            foreach (BonusModel bonus in bonusList)
            {
                bonusModel.BonusHealth += bonus.BonusHealth;
                bonusModel.BonusStamina += bonus.BonusStamina;
                bonusModel.BonusConcentration += bonus.BonusConcentration;

                bonusModel.BonusStrength += bonus.BonusStrength;
                bonusModel.BonusAgility += bonus.BonusAgility;
                bonusModel.BonusIntellect += bonus.BonusIntellect;

                bonusModel.BonusBlock += bonus.BonusBlock;
                bonusModel.BonusDodge += bonus.BonusDodge;
                bonusModel.BonusResist += bonus.BonusResist;
            }

            return bonusModel;
        }
        public bool EditCharacter(CharacterCreateModel editModel)
        {
            return characterRepository.UpdateCharacter(editModel);
        }
    }
}
