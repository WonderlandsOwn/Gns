using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Race
    {
        DAL_Race RaceRepository;
        
        public BLL_Race()
        {
            RaceRepository = new DAL_Race();
        }

        public List<RaceIndexModel> GetCompleteRaceIndex()
        {
            return RaceRepository.GetAllRaceAsIndexModel();
        }

        public List<IdAndName> GetBasicList()
        {
            return RaceRepository.GetAllAsIdAndName();
        }


        public bool CreateRace(RaceCreateModel createModel)
        {
            return RaceRepository.CreateNewRace(createModel);
        }
        //pending spell list

        //todo get race edit model

        //todo update race model
    }
}
