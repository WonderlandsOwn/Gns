using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Parsers;

namespace DAL
{
    public class DAL_Archtype : Repository<GnsEntities.Archtype>
    {
        public List<ArchtypeIndexRowModel> GetAllArchtypeAsIndexModel()
        {
            return GetAll()
                .Select(a => new ArchtypeIndexRowModel()
                {
                    ArchtypeId = a.ArchtypeId,
                    ArchtypeName = a.ArchtypeName,
                    ArchtypeShortDescription = a.ArchtypeShortDescription,
                    ArchtypeRankName = a.Rank.RankName
                }).ToList();
        }

        public BonusModel GetBonus(int id)
        {
            GnsEntities.ArchtypeBonu bonus = GetByID(id).ArchtypeBonu;

            return new BonusModel()
            {
                BonusHealth = bonus.BonusHealth,
                BonusStamina = bonus.BonusStamina,
                BonusConcentration = bonus.BonusConcentration,
                BonusStrength = bonus.BonusStrength,
                BonusAgility = bonus.BonusAgility,
                BonusIntellect = bonus.BonusIntellect,

                BonusBlock = bonus.BonusBlock,
                BonusDodge = bonus.BonusDodge,
                BonusResist = bonus.BonusResist
            };
        }

        public List<ListPair> GetAllListPair()
        {
            return GetAll()
                .Select(a => new ListPair()
                {
                    Id = a.ArchtypeId,
                    Name = a.ArchtypeName
                }).ToList();
        }

        public ArchtypeDetailModel GetDetailModel(int id)
        {
            GnsEntities.Archtype archtype= GetByID(id);
            return new ArchtypeDetailModel()
            {
                ArchtypeRankName = archtype.Rank.RankName,
                ArchtypeName = archtype.ArchtypeName,
                ArchtypeShortDescription = archtype.ArchtypeShortDescription,
                ArchtypeDescription = archtype.ArchtypeDescription,
                ArchtypeBonus = BonusModelParser.GetBonusModel(archtype.ArchtypeBonu)
                //ArchTypeSpells not yet implemented
            };
        }

        public List<ListPair> GetArchtypeListPairsByRank(int rank)
        {
            return GetAll()
                .Where(a => a.ArchtypeRankId == rank)
                .Select(a => new ListPair()
                {
                    Id = a.ArchtypeId,
                    Name = a.ArchtypeName
                }).ToList();
        }

        public List<ArchtypeIndexRowModel> GetArchtypeIndexByRank(int rank)
        {
            return GetAll()
                .Where(a => a.ArchtypeRankId == rank)
                .Select(a => new ArchtypeIndexRowModel()
                {
                    ArchtypeId = a.ArchtypeId,
                    ArchtypeName = a.ArchtypeName,
                    ArchtypeShortDescription = a.ArchtypeShortDescription,
                    ArchtypeRankName = a.Rank.RankName
                }).ToList();
        }

        public bool CreateNewArchtype(ArchtypeCreateModel createmodel)
        {
            GnsEntities.Archtype archtype = new GnsEntities.Archtype();

            archtype.ArchtypeName = createmodel.ArchtypeName;
            archtype.ArchtypeShortDescription = createmodel.ArchtypeShortDescription;
            archtype.ArchtypeDescription = createmodel.ArchtypeLongDescription;
            archtype.ArchtypeRankId = createmodel.ArchtypeRankId;

            archtype.ArchtypeBonu = new GnsEntities.ArchtypeBonu()
            {
                Archtype = archtype,
                ArchtypeId = archtype.ArchtypeId,
                BonusHealth = createmodel.ArchtypeBonus.BonusHealth,
                BonusStamina = createmodel.ArchtypeBonus.BonusStamina,
                BonusConcentration = createmodel.ArchtypeBonus.BonusConcentration,
                BonusStrength = createmodel.ArchtypeBonus.BonusStrength,
                BonusAgility = createmodel.ArchtypeBonus.BonusAgility,
                BonusIntellect = createmodel.ArchtypeBonus.BonusIntellect,
                BonusBlock = createmodel.ArchtypeBonus.BonusBlock,
                BonusDodge = createmodel.ArchtypeBonus.BonusDodge,
                BonusResist = createmodel.ArchtypeBonus.BonusResist    
            };
            return Insert(archtype);
        }
        public List<ListPair> GetRanks()
        {
            return new Repository<GnsEntities.Rank>()
                .GetAll()
                .Select(r => new ListPair()
                {
                    Id = r.RankId,
                    Name = r.RankName
                }).ToList();
        }
    }
}
