using PhoneStoreBackEnd.Resources;

namespace PhoneStoreBackEnd.Services
{
    public interface IAuthService
    {
        public AuthResource GetAuthData(string id, string role);
    }
}
