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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void HAdd(SubAbout h)
        {
            throw new NotImplementedException();
        }

        public void HDelete(SubAbout h)
        {
            throw new NotImplementedException();
        }

        public SubAbout HGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> HGetList()
        {
            return _subAboutDal.Getlist();
        }

        public void HUpdate(SubAbout h)
        {
            throw new NotImplementedException();
        }
    }
}
