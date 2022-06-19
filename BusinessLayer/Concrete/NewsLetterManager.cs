using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetter;
        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetter = newsLetter;
        }

        public void TAdd(NewsLetter entity)
        {
            _newsLetter.Insert(entity);
        }

        public void TDelete(NewsLetter entity)
        {
            throw new System.NotImplementedException();
        }

        public List<NewsLetter> TGetAll()
        {
            throw new System.NotImplementedException();
        }

        public NewsLetter TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(NewsLetter entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
