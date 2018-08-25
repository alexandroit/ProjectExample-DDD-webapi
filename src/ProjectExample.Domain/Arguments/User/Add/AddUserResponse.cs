using System;

namespace ProjectExample.Domain.Arguments.User.Add
{
    public class AddUserResponse
    {
        public AddUserResponse(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
