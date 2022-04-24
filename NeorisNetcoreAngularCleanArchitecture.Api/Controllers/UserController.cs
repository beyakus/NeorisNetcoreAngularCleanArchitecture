using NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities;
using NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities.Filters;
using NeorisNetcoreAngularCleanArchitecture.Core.Entities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace NeorisNetcoreAngularCleanArchitecture.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController: ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpGet(Name = nameof(Get))]
        public IActionResult Get([FromQuery]UserQuery filter)
        {
            var users = this.userService.Get();
            var response = new ApiResponse<PageList<Usuario>>(users);
            response.metadata = new Metadata(){
                CurrentPage =  users.CurrentPage,
                TotalPage =  users.TotalPage,
                PageSize =  users.PageSize,
                TotalCount =  users.TotalCount,
                HasPrevPage =  users.HasPrevPage,
                HasNextPage =  users.HasNextPage,
            };
            return Ok(response);
        }
        
    }
}