using ProjectExample.Domain.Entities.Base;
using ProjectExample.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectExample.Domain.Entities
{
    public class User : EntityBase
    {
        public Name Name { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }
    }
}
