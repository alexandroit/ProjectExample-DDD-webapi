using ProjectExample.Domain.Entities;
using System;

namespace ProjectExample.Domain.Interfaces.Repositories
{
    public interface IRepositoryUser
    {
        User Get(Guid id);
        User Get(string email, string password);
        void Save(User user);
        bool Exists(string email);
    }
}
