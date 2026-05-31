using InvestLens.Shared.Model;
using InvestLens.Shared.Model.Crud.User;

namespace InvestLens.Shared.DataAccess.Services;

public interface IAuthService
{
    Task<bool> CheckLoginUniqueAsync(string login);
    Task<(bool Success, string ErrorMessage)> RegisterAsync(RegistrationModel model);
    Task<(bool Success, UserModel? User, string ErrorMessage)> LoginAsync(LoginModel model);
}