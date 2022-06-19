using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericRepository<Comment>
    {
        List<Comment> GetCommentWithBlog();
    }
}
