using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
