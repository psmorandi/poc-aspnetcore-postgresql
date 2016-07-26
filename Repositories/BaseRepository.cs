using System.Data;
using Npgsql;

namespace Poc.AspnetCore.Api.Repositories
{
    public abstract class BaseRepository
    {
        protected IDbConnection GetConnection()
        {
            //TODO: connection string
            IDbConnection connection = new NpgsqlConnection("Server=10.1.1.102;Port=5432;Database=lic;User Id=psmorandi;Password = adm123;");
            connection.Open();
            return connection;
        }
    }
}