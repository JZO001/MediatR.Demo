using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Demo.Application.CQRS.User.Commands.CreateUser;

public record CreateUserCommand : IRequest<int>
{

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

}
