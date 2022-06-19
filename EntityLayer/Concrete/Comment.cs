using EntityLayer.Concrete.Common;
using System;

namespace EntityLayer.Concrete
{
    public class Comment : BaseEntity
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        public int BlogScore { get; set; }
    }

}
