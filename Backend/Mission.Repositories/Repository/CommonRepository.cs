using Mission.Entities;
using Mission.Entities.ViewModel;
using Mission.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.Repository
{
    public class CommonRepository(MissionDBContext dbContext) : ICommonRepository
    {
        private readonly MissionDBContext _dbContext = dbContext;

        public List<DropDownResponseModel> CountryList()
        {
            var countries = _dbContext.Countires
                .OrderBy(c => c.CountryName)
                .Select(c => new DropDownResponseModel(c.Id, c.CountryName))
                .ToList();

            return countries;
        }

        public List<DropDownResponseModel> CityList(int countryId)
        {
            var cities = _dbContext.Cities
                .Where(c => c.CountryId == countryId)
                .OrderBy(c => c.CityName)
                .Select(c => new DropDownResponseModel(c.Id, c.CityName))
                .ToList();

            return cities;
        }

        public List<DropDownResponseModel> MissionThemeList()
        {
            var missionThemes = _dbContext.MissionThemes
                .Where(mt => mt.Status == "active")
                .Select(mt => new DropDownResponseModel(mt.Id, mt.ThemeName))
                .Distinct()
                .ToList();

            return missionThemes;
        }

        public List<DropDownResponseModel> MissionSkillList()
        {
            var missionSkill = _dbContext.MissionSkills
                .Where(ms => ms.Status == "active")
                .Select(ms => new DropDownResponseModel(ms.Id, ms.SkillName))
                .ToList();

            return missionSkill;
        }


    }
}
