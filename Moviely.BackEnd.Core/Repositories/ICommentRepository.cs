using Moviely.BackEnd.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Core.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {

        public Task<List<Comment>> GetCommentsByMovieId(int id);

    }
}
