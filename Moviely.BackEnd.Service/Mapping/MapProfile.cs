using AutoMapper;
using Moviely.BackEnd.Core.DTOs;
using Moviely.BackEnd.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();

        }
    }
}
