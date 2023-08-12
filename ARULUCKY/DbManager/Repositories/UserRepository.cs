using Dapper;
using DbManager.Context;
using DbManager.Interfaces;
using DbManager.Models;

namespace DbManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context = new();

        public UserRepository() { /* \(-_-)/ */ }

        public async Task<bool> Exists(ulong telegramId)
        {
            using var con = _context.CreateConnection();
            var sql =
            $"""
                SELECT COUNT(1)
                FROM {nameof(User)}
                WHERE {nameof(User.TelegramID)} = @{nameof(telegramId)}
            """;
            return await con.QuerySingleAsync<ulong>(sql, new { telegramId }) > 0;
        }

        public async Task<User> Get(ulong telegramId)
        {
            using var con = _context.CreateConnection();
            var sql =
            $"""
                SELECT 
                      {nameof(User.TelegramID)}
                    , {nameof(User.FirstPullTime)}
                    , {nameof(User.LastPullTime)}
                    , {nameof(User.Role)}
                FROM {nameof(User)}
                WHERE {nameof(User.TelegramID)} = @{nameof(telegramId)}
            """;
            return await con.QuerySingleOrDefaultAsync<User>(sql, new { telegramId });
        }

        public async Task Add(User user)
        {
            using var con = _context.CreateConnection();
            var sql =
            $"""
                INSERT INTO {nameof(User)}
                ({nameof(User.TelegramID)}, {nameof(User.FirstPullTime)}, {nameof(User.LastPullTime)}, {nameof(User.Role)})
                VALUES 
                (@{nameof(User.TelegramID)}, @{nameof(User.FirstPullTime)}, @{nameof(User.LastPullTime)}, @{nameof(User.Role)})
            """;
            await con.ExecuteAsync(sql, user);
        }

        public async Task Update(User user)
        {
            using var con = _context.CreateConnection();
            var sql =
            $"""
                UPDATE {nameof(User)}
                SET 
                      {nameof(User.FirstPullTime)}  = @{nameof(User.FirstPullTime)}
                    , {nameof(User.LastPullTime)}   = @{nameof(User.LastPullTime)}
                    , {nameof(User.Role)}           = @{nameof(User.Role)}
                WHERE {nameof(User.TelegramID)}     = @{nameof(User.TelegramID)}
            """;
            await con.ExecuteAsync(sql, user);
        }

        public async Task Delete(ulong telegramId)
        {
            using var con = _context.CreateConnection();
            var sql =
            $"""
                DELETE FROM {nameof(User)}
                WHERE {nameof(User.TelegramID)} = @{nameof(telegramId)}
            """;
            await con.ExecuteAsync(sql, new { telegramId });
        }
    }
}
