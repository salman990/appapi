using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appapi.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int RestaurantId { get; set; }
    }
}
