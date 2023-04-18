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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void HAdd(About h)
        {
            _aboutDal.Insert(h);
        }

        public void HDelete(About h)
        {
            _aboutDal.Delete(h);
        }

        public About HGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> HGetList()
        {
           return _aboutDal.Getlist();
        }

        public void HUpdate(About h)
        {
            _aboutDal.Update(h);
        }
    }
}
