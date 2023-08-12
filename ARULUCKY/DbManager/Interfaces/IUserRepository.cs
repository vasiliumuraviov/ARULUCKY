using DbManager.Models;

namespace DbManager.Interfaces
{
    public interface IUserRepository
    {
        public Task<bool> Exists(ulong telegramId);

        public Task<User> Get(ulong telegramId);

        public Task Add(User user);

        public Task Update(User user);

        public Task Delete(ulong telegramId);
    }
}
