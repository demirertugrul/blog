using EntityLayer.Concrete.Common;
using System;

namespace EntityLayer.Concrete
{
    public class Notification : BaseEntity
    {
        public string Type { get; set; }
        public string TypeSembol { get; set; }
        public string Color { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
    }
}