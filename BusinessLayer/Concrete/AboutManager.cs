using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(About entity)
        {
            throw new System.NotImplementedException();
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetListAll();
        }

        public About TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(About entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
