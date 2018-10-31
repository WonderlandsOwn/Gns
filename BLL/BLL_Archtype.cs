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

        public List<ArchtypeIndexModel> GetCompleteArchtypeIndex()
        {
            return ArchtypeRepository.GetAllArchtypeAsIndexModel();
        }

        public List<IdAndName> GetBasicList()
        {
            return ArchtypeRepository.GetAllAsIdAndName();
        }

        public bool CreateArchtype(ArchtypeCreateModel createModel)
        {
            return ArchtypeRepository.CreateNewArchtype(createModel);
        }
        //pending spell list

        //todo archtype edit model

        //todo archtype update

    }
}
