using EntityLayer.Concrete.Common;
using System;

namespace EntityLayer.Concrete
{
    public class Contact : BaseEntity
    {
        public string UserName { get; set; }

        public string Mail { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}

