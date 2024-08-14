using Moviely.BackEnd.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Core.Services
{
    public interface ICommentService : IService<Comment>
    {
        public List<Comment> GetCommentsByMovieId(int id);
    }
}
