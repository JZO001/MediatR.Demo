using Demo.Application.Common.Interfaces;
using Demo.Domain.CQRS.Events;
using Demo.Domain.Entities;
using MediatR;

namespace Demo.Application.CQRS.User.Commands.CreateUser
{

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {

        private IMediator _mediator;
        private IUserStore _userStore;

        public CreateUserCommandHandler(IMediator mediator, IUserStore userStore)
        {
            _mediator = mediator;
            _userStore = userStore;
        }

        public Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new() { FirstName = request.FirstName, LastName = request.LastName };
            _userStore.Add(user);

            // send notification
            _mediator.Publish(new UserCreatedEvent(user));

            return Task.FromResult(user.Id);
        }

    }

}
