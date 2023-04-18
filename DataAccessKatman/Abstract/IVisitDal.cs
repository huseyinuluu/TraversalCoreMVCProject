using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.Abstract
{
    public interface IVisitDal : IGenericDal<Visit>
    {
        List<Visit> GetListWithVisitByWaitAppRoval(int id);
        List<Visit> GetListWithVisitByAppRoval(int id);
        List<Visit> GetListWithVisitByLast(int id);
    }
}
