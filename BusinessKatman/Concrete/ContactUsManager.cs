using BusinessKatman.Abstract;
using DataAccessKatman.Abstract;
using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void HAdd(ContactUs h)
        {
            _contactUsDal.Insert(h);
        }

        public void HContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void HDelete(ContactUs h)
        {
            throw new NotImplementedException();
        }

        public ContactUs HGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> HGetList()
        {
            return _contactUsDal.Getlist();
        }

        public List<ContactUs> HGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> HGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void HUpdate(ContactUs h)
        {
            throw new NotImplementedException();
        }
    }
}
