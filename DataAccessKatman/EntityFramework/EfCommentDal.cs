﻿using DataAccessKatman.Abstract;
using DataAccessKatman.Concrete;
using DataAccessKatman.Repository;
using EntityKatman.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x => x.DestinationID == id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
