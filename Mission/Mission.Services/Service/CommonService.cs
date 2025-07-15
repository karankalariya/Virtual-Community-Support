using Mission.Entities.ViewModel;
using Mission.Repositories.IRepository;
using Mission.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Service
{
    public class CommonService(ICommonRepository commonRepository) : ICommonService
    {
        private readonly ICommonRepository _commonRepository = commonRepository;

        public List<DropDownResponseModel> CountryList()
        {
            return _commonRepository.CountryList();
        }

        public List<DropDownResponseModel> CityList(int countryId)
        {
            return _commonRepository.CityList(countryId);
        }

        public List<DropDownResponseModel> MissionThemeList()
        {
            return _commonRepository.MissionThemeList();
        }

        public List<DropDownResponseModel> MissionSkillList()
        {
            return _commonRepository.MissionSkillList();
        }
    }
}
