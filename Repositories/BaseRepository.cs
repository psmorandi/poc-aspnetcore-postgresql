using System.Data;
using Npgsql;

namespace Poc.AspnetCore.Api.Repositories
{
    public abstract class BaseRepository
    {
        protected IDbConnection GetConnection(string connectionString)
        {
            //TODO: connection string
            IDbConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}