using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetCommentsByBlogID(int id)
        {
            return _commentDal.GetListAll(x => x.BlogID == id);
        }

        public List<Comment> GetCommentWithBlog()
        {
            return _commentDal.GetCommentWithBlog();
        }

        public void TAdd(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> TGetAll()
        {
            throw new System.NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Comment entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
