using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PieShop.Models
{
    public class Category
    {[Key]
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Desc { get; set; }
        public List<Pie> Pies { get; set; }

    }
}