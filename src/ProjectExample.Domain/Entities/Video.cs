using ProjectExample.Domain.Entities.Base;
using ProjectExample.Domain.Enums;

namespace ProjectExample.Domain.Entities
{
    public class Video : EntityBase
    {
        public Channel Channel { get; set; }

        public PlayList PlayList { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }

        public string PlayListOrder { get; set; }

        public User UserSuggested { get; set; }

        public EnumStatus Status { get; set; }
    }
}
