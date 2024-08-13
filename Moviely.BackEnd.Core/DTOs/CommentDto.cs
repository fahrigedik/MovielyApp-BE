using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Core.DTOs
{
    public class CommentDto : BaseDto
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string description { get; set; }
        public int movieScore { get; set; }
        public int movieId { get; set; }
    }
}
