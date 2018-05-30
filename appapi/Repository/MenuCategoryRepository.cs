using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Data;
using appapi.Models;
using Npgsql;
using Dapper;

namespace appapi.Repository
{
    public class MenuCategoryRepository:IMenuCategoryRepository
    {
        private readonly string _connectionString;
        public MenuCategoryRepository(IOptions<Settings> settings)
        {
            _connectionString = settings.Value.databaseConnectionString;
        }
        public IEnumerable<MenuCategory> GetAllMenuCategories()
        {
            string strSql = "SELECT * FROM Menu_Categories";
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<MenuCategory>(strSql).AsList<MenuCategory>();
            }
        }
    }
}
