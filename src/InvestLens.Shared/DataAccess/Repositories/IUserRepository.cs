using InvestLens.Shared.Model.Entities;

namespace InvestLens.Shared.DataAccess.Repositories;

public interface IUserRepository : IBaseRepository
{
    Task<bool> CheckLoginUnique(string login);
    Task<bool> CreateUser(User user);
    Task<User?> GetUserByLogin(string login);
}