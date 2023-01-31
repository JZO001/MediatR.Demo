using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;
using MediatR;

namespace Demo.Application.CQRS.User.Queries.GetUsers;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, ICollection<UserEntity>>
{

    private IUserStore _userStore;

    public GetUsersQueryHandler(IUserStore userStore)
    {
        _userStore = userStore;
    }

    public Task<ICollection<UserEntity>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_userStore.Get());
    }

}
