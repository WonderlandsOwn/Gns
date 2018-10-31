using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Archtype : Repository<GnsEntities.Archtype>
    {
        public List<ArchtypeIndexModel> GetAllArchtypeAsIndexModel()
        {
            return GetAll().Select(a =>
            new ArchtypeIndexModel()
            {
                ArchtypeId = a.ArchtypeId,
                ArchtypeName = a.ArchtypeName,
                ArchtypeShortDescription = a.ArchtypeDetail.ArchtypeShortDescription
            }).ToList();
        }

        public List<IdAndName> GetAllAsIdAndName()
        {
            return GetAll().Select(a => new IdAndName()
            {
                Id = a.ArchtypeId,
                Name = a.ArchtypeName
            }).ToList();
        }

        public bool CreateNewArchtype(ArchtypeCreateModel createmodel)
        {
            GnsEntities.Archtype archtype = new GnsEntities.Archtype();


            archtype.ArchtypeName = createmodel.ArchtypeName;
            archtype.ArchtypeDetail = new GnsEntities.ArchtypeDetail()
            {
                Archtype = archtype,
                ArchtypeId = archtype.ArchtypeId,
                ArchtypeShortDescription = createmodel.ArchtypeShortDescription,
                ArchtypeDescription = createmodel.ArchtypeDescription
            };
            archtype.ArchtypeBonu = new GnsEntities.ArchtypeBonu()
            {
                Archtype = archtype,
                ArchtypeId = archtype.ArchtypeId,
                BonusAgility = createmodel.BonusAgility,
                BonusStrength = createmodel.BonusStrength,
                BonusConstitution = createmodel.BonusConstitution,
                BonusEndurance = createmodel.BonusEndurance,
                BonusFortitude = createmodel.BonusFortitude,
                BonusHealth = createmodel.BonusHealth,
                BonusIntellect = createmodel.BonusIntellect,
                BonusStamina = createmodel.BonusStamina
            };
            return Insert(archtype);       
        }
    }
}
