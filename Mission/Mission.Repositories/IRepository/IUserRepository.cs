using Mission.Entities.ViewModel;
using Mission.Entities.ViewModel.Login;
using Mission.Entities.ViewModel.User;
using Mission.Entities.ViewModels.User;

namespace Mission.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<(UserLoginResponseModel? response, string message)> LoginUser(UserLoginRequestModel model);

        Task<List<UserResponseModel>> GetUsersAsync();

         Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);
        Task<(bool response, string message)> UpdateUserAsync(UpdateUserRequestModel model, string imageUploadPath);
        Task<bool> DeleteUser(int userId);

    }
}
