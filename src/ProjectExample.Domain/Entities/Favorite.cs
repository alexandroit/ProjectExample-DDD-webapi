using ProjectExample.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectExample.Domain.Entities
{
    public class Favorite : EntityBase
    {
        public Video Video { get; set; }

        public User User { get; set; }
    }
}
