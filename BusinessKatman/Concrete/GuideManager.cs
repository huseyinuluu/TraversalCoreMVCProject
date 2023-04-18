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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void HAdd(Guide h)
        {
            _guideDal.Insert(h);
        }

        public void HChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void HChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void HDelete(Guide h)
        {
            _guideDal.Delete(h);
        }

        public Guide HGetByID(int id)
        {
            return _guideDal.GetByID(id);
        }

        public List<Guide> HGetList()
        {
            return _guideDal.Getlist();
        }

        public void HUpdate(Guide h)
        {
            _guideDal.Update(h);
        }
    }
}
