using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviely.BackEnd.Core.DTOs;

namespace Moviely.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.statusCode == 204)
            {
                return new ObjectResult(null) { StatusCode = response.statusCode };
            }

            return new ObjectResult(response) { StatusCode = response.statusCode };


        }


    }
}
