using Moviely.BackEnd.Core.Entities;
using Moviely.BackEnd.Core.Repositories;
using Moviely.BackEnd.Core.Services;
using Moviely.BackEnd.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Service.Services
{
    public class CommentService : Service<Comment>, ICommentService
    {

        private readonly ICommentRepository _commentRepository;
        public CommentService(IGenericRepository<Comment> genericRepository, IUnitOfWork unitOfWork,ICommentRepository commentRepository) : base(genericRepository, unitOfWork)
        {
            _commentRepository = commentRepository;
        }

        public List<Comment> GetCommentsByMovieId(int id)
        {
           return _commentRepository.GetCommentsByMovieId(id);
        }
    }
}
