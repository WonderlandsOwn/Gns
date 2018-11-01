using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Archtype
    {
        DAL_Archtype ArchtypeRepository;

        public BLL_Archtype()
        {
            ArchtypeRepository = new DAL_Archtype();
        }

        public BonusModel GetArchTypeBonus (int id)
        {
            return ArchtypeRepository.GetBonus(id);
        }
        public List<ArchtypeIndexRowModel> GetCompleteArchtypeIndex()
        {
            return ArchtypeRepository.GetAllArchtypeAsIndexModel();
        }

        public List<ArchtypeIndexRowModel> GetArchtypeIndexByRank(int rank)
        {
            return ArchtypeRepository.GetArchtypeIndexByRank(rank);
        }
        public List<ListPair> GetBasicList()
        {
            return ArchtypeRepository.GetAllListPair();
        }

        public List<ListPair> GetBasicList(int rank)
        {
            return ArchtypeRepository.GetArchtypeListPairsByRank(rank);
        }
        public bool CreateArchtype(ArchtypeCreateModel createModel)
        {
            return ArchtypeRepository.CreateNewArchtype(createModel);
        }

        public List<ListPair> GetAvailableRanks()
        {
            return ArchtypeRepository.GetRanks();
        }

        public ArchtypeDetailModel GetArchtypeDetails(int id)
        {
            return ArchtypeRepository.GetDetailModel(id);
        }
        //pending spell list

        //todo archtype edit model

        //todo archtype update

    }
}
