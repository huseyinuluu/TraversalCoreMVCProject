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
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void HAdd(Destination h)
        {
            _destinationDal.Insert(h);
        }

        public void HDelete(Destination h)
        {
            _destinationDal.Delete(h);
        }

        public Destination HGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public Destination HGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> HGetList()
        {
           return _destinationDal.Getlist();
        }

        public void HUpdate(Destination h)
        {
            _destinationDal.Update(h);
        }
    }
}
