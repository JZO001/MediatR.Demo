using Demo.Domain.Entities;
using MediatR;

namespace Demo.Application.CQRS.User.Queries.GetUsers
{

    public record GetUsersQuery : IRequest<ICollection<UserEntity>>
    {
    }

}
