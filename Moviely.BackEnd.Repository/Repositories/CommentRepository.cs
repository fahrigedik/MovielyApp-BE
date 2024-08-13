using Moviely.BackEnd.Core.Entities;
using Moviely.BackEnd.Core.Repositories;
using Moviely.BackEnd.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Repository.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context)
        {

        }

        public List<Comment> GetCommentsByMovieId(int id)
        {
            var data = _context.Comments.Where(x => x.movieId == id).ToList();
            return data;
        }
    }
}
