using System.Security;

namespace InvestLens.Shared.Models;

public class LoginModel
{
    public string Login { get; set; } = string.Empty;
    public SecureString? Password { get; set; }
}