using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }


        public void TAdd(Contact entity)
        {
            _contactdal.Insert(entity);
        }

        public void TDelete(Contact entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> TGetAll()
        {
            throw new System.NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Contact entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
