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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void HAdd(Comment h)
        {
            _commentDal.Insert(h);
        }

        public void HDelete(Comment h)
        {
            _commentDal.Delete(h);
        }

        public Comment HGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> HGetList()
        {
            return _commentDal.Getlist();
        }

        public List<Comment> HGetDestinationByID(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public void HUpdate(Comment h)
        {
            throw new NotImplementedException();
        }

        public List<Comment> HGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> HGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }
    }
}
