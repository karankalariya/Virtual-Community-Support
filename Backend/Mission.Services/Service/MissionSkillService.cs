using Mission.Entities.ViewModel.MissionSkill;
using Mission.Repositories.IRepository;
using Mission.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Service
{
    public class MissionSkillService(IMissionSkillRepository missionSkillRepository ) : IMissionSkillService
    {
        private readonly IMissionSkillRepository _missionSkillRepository = missionSkillRepository;
        public async Task AddMissionSkillAsync(UpsertMissionSkillRequestModel model)
        {
            await _missionSkillRepository.AddMissionSkillAsync(model);
            return;
        }

        public async Task<List<MissionSkillResponseModel>> GetMissionSkillAsync()
        {
            return await _missionSkillRepository.GetMissionSkillAsync();
        }
        public async Task<MissionSkillResponseModel?> GetMissionSkillByIdAsync(int missionSkillId)
        {
            return await _missionSkillRepository.GetMissionSkillByIdAsync(missionSkillId);
        }

        public async Task<bool> UpdateMissionSkillAsync(UpsertMissionSkillRequestModel model)
        {
           return await _missionSkillRepository.UpdateMissionSkillAsync(model);
        }
        public async Task<bool> DeleteMissionSkill(int id)
        {
            return await _missionSkillRepository.DeleteMissionSkill(id);

        }
    }
}
