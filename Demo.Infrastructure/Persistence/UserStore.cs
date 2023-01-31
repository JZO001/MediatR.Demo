using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;

namespace Demo.Infrastructure.Persistence
{

    public class UserStore : IUserStore
    {

        private readonly List<UserEntity> _users = new();

        public ICollection<UserEntity> Get()
        {
            return _users.AsReadOnly();
        }

        public int Add(UserEntity user)
        {
            user.Id = _users.Count == 0 ? 1 : _users.Max(x => x.Id) + 1;
            _users.Add(user);
            return user.Id;
        }

    }

}