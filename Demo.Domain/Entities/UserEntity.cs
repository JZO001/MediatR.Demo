using Demo.Domain.Common;

namespace Demo.Domain.Entities;

public class UserEntity : EntityBase
{

    public string FirstName { get; init; } = string.Empty; 
    
    public string LastName { get; init;} = string.Empty;

}
