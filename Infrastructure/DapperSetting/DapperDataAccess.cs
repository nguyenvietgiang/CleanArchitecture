using Application;
using Dapper;
using Npgsql;

namespace Infrastructure.DapperSetting
{
    public class DapperDataAccess : IDataAcess
    {
        private readonly string _connectionString;

        public DapperDataAccess(string connectionString = "Server=localhost;Port=5432;Database=CleanArchitecture;User Id=postgres;Password=vip1111;")
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<T>> GetData<T, P>(string query, P parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                return await connection.QueryAsync<T>(query, parameters);
            }
        }

        public async Task ExecuteCommand<P>(string command, P parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(command, parameters);
            }
        }
    }
}
