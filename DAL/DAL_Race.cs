using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class DAL_Race : Repository<GnsEntities.Race>
    {
        public List<RaceIndexModel> GetAllRaceAsIndexModel()
        {
            return GetAll().Select(r =>
            new RaceIndexModel()
            {
                RaceId = r.RaceId,
                RaceName = r.RaceName,
                RaceShortDescription = r.RaceDetail.RaceShortDescription
            }).ToList();
        }

        public List<IdAndName> GetAllAsIdAndName()
        {
            return GetAll().Select(r => new IdAndName()
            {
                Id = r.RaceId,
                Name = r.RaceName
            }).ToList();
        }

        public bool CreateNewRace(RaceCreateModel createmodel)
        {
            GnsEntities.Race race = new GnsEntities.Race();

            race.RaceName = createmodel.RaceName;
            race.RaceDetail = new GnsEntities.RaceDetail()
            {
                Race = race,
                RaceId = race.RaceId,
                RaceShortDescription = createmodel.RaceShortDescription,
                RaceDescription = createmodel.RaceDescription
            };
            race.RaceBonu = new GnsEntities.RaceBonu()
            {
                Race = race,
                RaceId = race.RaceId,
                BonusAgility = createmodel.BonusAgility,
                BonusStrength = createmodel.BonusStrength,
                BonusConstitution = createmodel.BonusConstitution,
                BonusEndurance = createmodel.BonusEndurance,
                BonusFortitude = createmodel.BonusFortitude,
                BonusHealth = createmodel.BonusHealth,
                BonusIntellect = createmodel.BonusIntellect,
                BonusStamina = createmodel.BonusStamina
            };
            return Insert(race);
        }
    }
}
