using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessKatman.Abstract
{
    public interface IGuideService : IGenericService<Guide> 
    {
        void HChangeToTrueByGuide(int id);
        void HChangeToFalseByGuide(int id);
    }
}
