using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.Abstract
{
    public interface IVisitService : 
        IGenericService<Visit>
    {
        List<Visit> GetListWithVisitByWaitAppRoval(int id);
        List<Visit> GetListWithVisitByLast(int id);
        List<Visit> GetListWithVisitByAppRoval(int id);
    }
}
