using EntityLayer.Concrete.Common;
using System;

namespace EntityLayer.Concrete
{
    public class Message2 : BaseEntity
    {
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public Writer SenderWriter { get; set; }
        public Writer ReceiverWriter { get; set; }
    }
}
