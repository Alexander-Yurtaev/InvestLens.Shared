namespace InvestLens.Shared.Models.Services;

public interface IAuthManager
{
    UserInfo? CurrentUser { get; }
    void SetCurrentUser(UserInfo info);
}