    using Microsoft.AspNetCore.Mvc;
using Mission.Entities.ViewModel;
using Mission.Entities.ViewModel.MissionSkill;
using Mission.Services.IService;
using Mission.Services.Service;
using System.Threading.Tasks;

namespace Mission.Api.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class MissionSkillController(IMissionSkillService missionSkillService) : ControllerBase
    {
        private readonly IMissionSkillService _missionSkillService = missionSkillService;
        [HttpPost]
        [Route("AddMissionSkill")]
        public async Task<IActionResult> AddMissionSkill(UpsertMissionSkillRequestModel model)
        {
            await _missionSkillService.AddMissionSkillAsync(model);

            var result = new ResponseResult()
            {
                Result = ResponseStatus.Success, Message = "New Mission Skill Added Successfully"
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetMissionSkillList")]
        public async Task<IActionResult> GetAddMissionSkill()
        {
            var response = await _missionSkillService.GetMissionSkillAsync();

            var result = new ResponseResult()
            {
                Data = response,
                Result = ResponseStatus.Success,
            };
            return Ok(result);

        }

        [HttpGet]
        [Route("GetMissionSkillById/{id:int}")]
        public async Task<IActionResult> GetMissionSkillById(int id)
        {
            var response = await _missionSkillService.GetMissionSkillByIdAsync(id);

            var result = new ResponseResult();
        
             if(response==null)
            {
                result.Result = ResponseStatus.Error;
                result.Message = "Mission skill record Not found";
                return NotFound(result);

            }

            result.Result = ResponseStatus.Success;
            result.Data = response;
            return Ok(result);
        }

        [HttpPost]
        [Route("UpdateMissionSkill")]
        public async Task<IActionResult> UpdateMissionSkill(UpsertMissionSkillRequestModel model)
        {
           var response= await _missionSkillService.UpdateMissionSkillAsync(model);
            var result = new ResponseResult();

            if (response)
            {
                result.Result = ResponseStatus.Success;
                return Ok(result);
            }
            else
            {
                result.Result = ResponseStatus.Error;
                result.Message = "Mission Skill not found";
                return NotFound(result);
            }
         }

        [HttpDelete]
        [Route("DeleteMissionSkill/{id:int}")]
        public async Task<IActionResult> DeleteMissionSkill(int id)
        {
            var response = await _missionSkillService.DeleteMissionSkill(id);
            var result = new ResponseResult();

            if (response)
            {
                result.Result = ResponseStatus.Success;
                return Ok(result);
            }
            else
            {
                result.Result = ResponseStatus.Error;
                result.Message = "Mission Skill not found";
                return NotFound(result);
            }


        }
    }
   
}