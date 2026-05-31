namespace InvestLens.Shared.Model.Services;

public interface IAuthManager
{
    UserInfo? CurrentUser { get; }
    void SetCurrentUser(UserInfo info);
}