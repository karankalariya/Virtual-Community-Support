using Mission.Entities.ViewModel;
using Mission.Entities.ViewModel.Login;
using Mission.Entities.ViewModel.User;
using Mission.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IUserService
    {
        Task<ResponseResult> LoginUser(UserLoginRequestModel model);

        Task<List<UserResponseModel>> GetUsersAsync();
         Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);
        Task<ResponseResult> UpdateUserAsync(UpdateUserRequestModel model, string contentRootPath);

        Task<bool> DeleteUser(int userId);




    }
}