using Shared;
using System.Data.Common;
using System.Data.SQLite;

namespace DbManager.Context
{
    internal class DataContext
    {
        public DataContext() { }

        public DbConnection CreateConnection()
        {
            return new SQLiteConnection(ConfigurationWrap.DB_CONNECTION);
        }
    }
}
