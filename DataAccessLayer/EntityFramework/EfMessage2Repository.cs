using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetSendBoxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2s.Include(x => x.ReceiverWriter).Where(y => y.SenderID == id).ToList();
            }
        }

        public List<Message2> GetInBoxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2s.Include(x => x.SenderWriter).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }
}
