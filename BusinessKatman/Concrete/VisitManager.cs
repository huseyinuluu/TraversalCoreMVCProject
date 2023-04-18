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
    public class VisitManager : IVisitService
    {
        IVisitDal _visitDal;

        public VisitManager(IVisitDal visitDal)
        {
            _visitDal = visitDal;
        }

        public List<Visit> GetListWithVisitByAppRoval(int id)
        {
            return _visitDal.GetListWithVisitByAppRoval(id);
        }

        public List<Visit> GetListWithVisitByLast(int id)
        {
            return _visitDal.GetListWithVisitByLast(id);
        }

        public List<Visit> GetListWithVisitByWaitAppRoval(int id)
        {
          return _visitDal.GetListWithVisitByWaitAppRoval(id);
        }

        public void HAdd(Visit h)
        {
            _visitDal.Insert(h);
        }

        public void HDelete(Visit h)
        {
            throw new NotImplementedException();
        }

        public Visit HGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Visit> HGetList()
        {
            throw new NotImplementedException();
        }

        public void HUpdate(Visit h)
        {
            throw new NotImplementedException();
        }
    }
}
