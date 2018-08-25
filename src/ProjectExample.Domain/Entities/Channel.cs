using ProjectExample.Domain.Entities.Base;

namespace ProjectExample.Domain.Entities
{
    public class Channel : EntityBase
    {
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public User User { get; set; }
    }
}
