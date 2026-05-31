using System.Security;

namespace InvestLens.Shared.Model;

public class LoginModel
{
    public string Login { get; set; } = string.Empty;
    public SecureString? Password { get; set; }
}