using Demo.Domain.CQRS.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Demo.Application.CQRS.User.EventHandlers;

public class UserCreatedEventHandler : INotificationHandler<UserCreatedEvent>
{

    private ILogger<UserCreatedEventHandler> _logger;

    public UserCreatedEventHandler(ILogger<UserCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("User created notification");

        return Task.CompletedTask;
    }

}
