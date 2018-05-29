using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace appapi.Repository
{
    public class MenuRepository
    {
        private readonly string _connectionString;
        public MenuRepository(IOptions<Settings> settings)
        {
            _connectionString = settings.Value.databaseConnectionString;
        }
        public IEnumerable<T> GetAll<T>(string sqlQuery)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<T>(sqlQuery).AsList<T>();
            }
        }
    }
}

