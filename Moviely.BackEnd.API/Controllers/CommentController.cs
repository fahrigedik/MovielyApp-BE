using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviely.BackEnd.Core.DTOs;
using Moviely.BackEnd.Core.Entities;
using Moviely.BackEnd.Core.Services;
using System.Runtime.InteropServices;

namespace Moviely.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : CustomBaseController
    {


        private readonly IMapper _mapper;
        private readonly IService<Comment> _genericService;
        private readonly ICommentService _commentService;

        public CommentController(IMapper mapper, IService<Comment> genericService, ICommentService commentService)
        {
            _mapper = mapper;
            _genericService = genericService;
            _commentService = commentService;
        }




        [HttpPost]
        public async Task<IActionResult> AddComment(CommentDto commentDto)
        {
            await _commentService.AddAsync(_mapper.Map<Comment>(commentDto));

            return CreateActionResult<CommentDto>(CustomResponseDto<CommentDto>.Success(200, commentDto));          
        }



        [HttpGet("[action]")]
        public async Task<IActionResult> GelAll()
        {

            var comments = _commentService.GetAll();
            var commentsDtos = _mapper.Map<List<CommentDto>>(comments);

            return CreateActionResult<List<CommentDto>>(CustomResponseDto<List<CommentDto>>.Success(200, commentsDtos));
        }


        [HttpGet("Movie/{id}")]
        public async Task<IActionResult> GetCommentsByMovieId(int id)
        {
            var comments = await _commentService.GetCommentsByMovieId(id);
            var commentsDtos = _mapper.Map<List<CommentDto>>(comments);

            return CreateActionResult<List<CommentDto>>(CustomResponseDto<List<CommentDto>>.Success(200, commentsDtos));
        }


    }
}
