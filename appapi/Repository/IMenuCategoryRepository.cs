using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appapi.Models;

namespace appapi.Repository
{
    public interface IMenuCategoryRepository
    {
        IEnumerable<MenuCategory> GetAllMenuCategories();
    }
}
