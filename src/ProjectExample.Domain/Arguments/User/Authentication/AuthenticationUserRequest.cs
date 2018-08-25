using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectExample.Domain.Arguments.User.Authentication
{
    public class AuthenticationUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
