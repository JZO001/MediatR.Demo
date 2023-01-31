using Demo.Domain.Entities;

namespace Demo.Application.Common.Interfaces
{

    public interface IUserStore
    {

        ICollection<UserEntity> Get();

        int Add(UserEntity user);

    }

}
