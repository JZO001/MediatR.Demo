using Demo.Domain.Common;
using Demo.Domain.Entities;

namespace Demo.Domain.CQRS.Events;

public class UserCreatedEvent : EventBase
{

    public UserCreatedEvent(UserEntity user) 
    { 
        User = user;
    }

    public UserEntity User { get; }

}
