using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mission.Entities;
using Mission.Entities.Models;
using Mission.Entities.ViewModel.MissionSkill;
using Mission.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Mission.Repositories.Repository
{
    public class MissionSkillRepository(MissionDBContext DbContext) : IMissionSkillRepository
    {
        private readonly MissionDBContext   _dbContext = DbContext;
        public async Task AddMissionSkillAsync(UpsertMissionSkillRequestModel model)
        {
            var missionSkill = new MissionSkill()
            {
             SkillName= model.SkillName,
             Status = model.Status
            };
            _dbContext.MissionSkills.Add(missionSkill);

           await _dbContext.SaveChangesAsync();

        } 

        public async Task<List<MissionSkillResponseModel>> GetMissionSkillAsync()
        {
            return await _dbContext.MissionSkills.Select(m => new MissionSkillResponseModel(m)).ToListAsync();
        }


        public async Task<MissionSkillResponseModel?> GetMissionSkillByIdAsync(int missionSkillId)
        {
            var missionSkill = await _dbContext.MissionSkills.FindAsync(missionSkillId);

            if (missionSkill == null)
                return null;

            return new MissionSkillResponseModel(missionSkill);
           
        }

        public async Task<bool> UpdateMissionSkillAsync(UpsertMissionSkillRequestModel model)
        {
            var missionSkill =  _dbContext.MissionSkills.Find(model.Id);

            if (missionSkill == null)
                return false;
          

            missionSkill.SkillName = model.SkillName;
            missionSkill.Status = model.Status;

            _dbContext.MissionSkills.Update(missionSkill);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMissionSkill(int id)
        {

            var missionSkill = _dbContext.MissionSkills.Find(id);

            if (missionSkill == null)
                return false;

            _dbContext.MissionSkills.Remove(missionSkill);
            await _dbContext.SaveChangesAsync();
            return true;


        }

    }
}
