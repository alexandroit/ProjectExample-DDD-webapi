using ProjectExample.Domain.Entities.Base;
using ProjectExample.Domain.Enums;

namespace ProjectExample.Domain.Entities
{
    public class PlayList : EntityBase
    {
        public string Name { get; set; }

        public User User { get; set; }

        public EnumStatus Status { get; set; }
    }
}
