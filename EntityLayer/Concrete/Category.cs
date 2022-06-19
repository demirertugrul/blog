using EntityLayer.Concrete.Common;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
