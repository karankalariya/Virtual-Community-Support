using Mission.Entities.ViewModel.MissionSkill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IMissionSkillService
    {
        Task AddMissionSkillAsync(UpsertMissionSkillRequestModel model);
        Task<List<MissionSkillResponseModel>> GetMissionSkillAsync();
        Task<MissionSkillResponseModel?> GetMissionSkillByIdAsync(int missionSkillId);
        Task<bool> UpdateMissionSkillAsync(UpsertMissionSkillRequestModel model);
        Task<bool> DeleteMissionSkill(int id);

    }
}
