using Demo.Application.CQRS.User.Commands.CreateUser;
using Demo.Application.CQRS.User.Queries.GetUsers;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebAPI.Controllers;

//[ApiController]
//[Route("api/[controller]")]
public class UserController : ApiControllerBase
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ICollection<UserEntity>> Get()
    {
        return await Mediator.Send(new GetUsersQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateUserCommand command)
    {
        if (ModelState.IsValid)
        {
            return await Mediator.Send(command);
        }

        return BadRequest();
    }

}
