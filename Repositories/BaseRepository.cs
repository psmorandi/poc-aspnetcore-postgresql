using System.Data;

namespace Poc.AspnetCore.Api.Repositories
{
    public abstract class BaseRepository
    {
        protected IDbConnection GetConnection()
        {
            //TODO: connection string
            IDbConnection connection = new Npgsql.NpgsqlConnection();
            connection.Open();
            return connection;
        }
    }
}