using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.Abstract
{
    public interface IDestinationDal: IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
    }
}
