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

        public MenuCategory GetMenuCategory(int id)
        {
            string strSql = "SELECT * FROM Menu_Categories where id = @Id";
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var menuCategory = db.QuerySingle<MenuCategory>(strSql, new { Id = id });
                return menuCategory;
            }
        }

        public bool CreateMenuCategory(MenuCategory menuCategoryModel)
        {
            string strSql = "INSERT INTO Menu_Categories(name,description,parent_id,restaurant_id) VALUES(@Name,@Description,@ParentId,@RestaurantId)";
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var affectedRows = db.Execute(strSql, new
                {
                    menuCategoryModel.Name,
                    menuCategoryModel.Description,
                    menuCategoryModel.ParentId,
                    menuCategoryModel.RestaurantId
                });

                return affectedRows > 0 ? true : false;
            }
        }

    }
}
