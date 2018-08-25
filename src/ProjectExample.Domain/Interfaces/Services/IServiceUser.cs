using ProjectExample.Domain.Arguments.User.Add;
using ProjectExample.Domain.Arguments.User.Authentication;

namespace ProjectExample.Domain.Interfaces.Services
{
    public interface IServiceUser
    {
        AddUserResponse Add(AddUserRequest user);
        AuthenticationUserResponse Authentication(AuthenticationUserRequest user);
    }
}
