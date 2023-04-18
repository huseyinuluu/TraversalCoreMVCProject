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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void HAdd(AppUser h)
        {
            throw new NotImplementedException();
        }

        public void HDelete(AppUser h)
        {
            throw new NotImplementedException();
        }

        public AppUser HGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> HGetList()
        {
            return _appUserDal.Getlist();
        }

        public void HUpdate(AppUser h)
        {
            throw new NotImplementedException();
        }
    }
}
