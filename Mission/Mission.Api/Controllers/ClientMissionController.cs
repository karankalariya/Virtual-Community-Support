using Microsoft.AspNetCore.Mvc;
using Mission.Entities.ViewModel;
using Mission.Entities.ViewModel.Mission;
using Mission.Services.IService;

namespace Mission.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMissionController(IMissionService missionService) : ControllerBase  
    {
        private readonly IMissionService _missionService = missionService;

        [HttpGet]
        [Route("ClientSideMissionList/{userId:int}")]
        public async Task<IActionResult> GetClientSideMissionList(int userId)
        {
           var response = await _missionService.GetClientSideMissionList(userId);
            var result = new ResponseResult() { Result = ResponseStatus.Success , Data=response };
            return Ok(result);
        }

        [HttpPost]
        [Route("ApplyMission")]
        public async Task<IActionResult> ApplyMission(ApplyMissionRequestModel model)
        {
            var (response, message) = await _missionService.ApplyMission(model);

            var result = new ResponseResult() { Message = message};

            if (!response)
            {
                result.Result = ResponseStatus.Error;
                if (message == "Not Found")
                {
                    return NotFound(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }

            result.Result = ResponseStatus.Success;
            return Ok(result);
        }



    }
}
