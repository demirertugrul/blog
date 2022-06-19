using EntityLayer.Concrete.Common;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Writer : BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<Blog> Blogs { get; set; }

        public virtual ICollection<Message2> SenderMessages { get; set; }

        public virtual ICollection<Message2> ReceiverMessages { get; set; }

    }
}
