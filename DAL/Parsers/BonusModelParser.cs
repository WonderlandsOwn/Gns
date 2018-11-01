using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Parsers
{
    static public class BonusModelParser
    {
        static public BonusModel GetBonusModel (GnsEntities.ArchtypeBonu archtypeBonu)
        {
            return new BonusModel()
            {
                BonusHealth = archtypeBonu.BonusHealth,
                BonusStamina = archtypeBonu.BonusStamina,
                BonusConcentration = archtypeBonu.BonusConcentration,
                BonusStrength = archtypeBonu.BonusStrength,
                BonusAgility = archtypeBonu.BonusAgility,
                BonusIntellect = archtypeBonu.BonusIntellect,
                BonusBlock = archtypeBonu.BonusBlock,
                BonusDodge = archtypeBonu.BonusDodge,
                BonusResist = archtypeBonu.BonusResist
            };
        }

        static public GnsEntities.ArchtypeBonu GetBonusEntity(BonusModel bonusModel)
        {
            return new GnsEntities.ArchtypeBonu()
            {
                BonusHealth = bonusModel.BonusHealth,
                BonusStamina = bonusModel.BonusStamina,
                BonusConcentration = bonusModel.BonusConcentration,
                BonusStrength = bonusModel.BonusStrength,
                BonusAgility = bonusModel.BonusAgility,
                BonusIntellect = bonusModel.BonusIntellect,
                BonusBlock = bonusModel.BonusBlock,
                BonusDodge = bonusModel.BonusDodge,
                BonusResist = bonusModel.BonusResist
            };
        }
    }
}
