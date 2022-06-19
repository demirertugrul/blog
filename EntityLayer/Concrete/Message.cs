using EntityLayer.Concrete.Common;
using System;

namespace EntityLayer.Concrete
{
    public class Message : BaseEntity
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
    }
}
