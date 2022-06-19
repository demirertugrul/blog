using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public List<Writer> GetWriterByID(int id)
        {
            return _writerdal.GetListAll(x => x.ID == id);
        }

        public void TAdd(Writer entity)
        {
            _writerdal.Insert(entity);
        }

        public void TDelete(Writer entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Writer> TGetAll()
        {
            throw new System.NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public void TUpdate(Writer entity)
        {
            _writerdal.Update(entity);
        }
    }
}
