using ProjectExample.Domain.Arguments.User.Add;
using ProjectExample.Domain.Arguments.User.Authentication;
using ProjectExample.Domain.Entities;
using ProjectExample.Domain.Interfaces.Repositories;
using ProjectExample.Domain.Interfaces.Services;
using System;

namespace ProjectExample.Domain.Services
{
    public class ServiceUser : IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }
        public AddUserResponse Add(AddUserRequest user)
        {
            if(user == null)
            {

            }
            var user = new User();
            _repositoryUser.Save(user);
        }

        public AuthenticationUserResponse Authentication(AuthenticationUserRequest user)
        {
            throw new NotImplementedException();
        }
    }
}
