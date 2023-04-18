using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> HGetDestinationByID(int id);
        List<Comment> HGetListCommentWithDestination();
        public List<Comment> HGetListCommentWithDestinationAndUser(int id);
    }
}
