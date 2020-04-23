using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepo:ICategoryRepo
    {
        public IEnumerable<Category> AllCat => new List<Category>
        {
            new Category{CatId=1,CatName="Fruit Pies",Desc="All-Fruites"},
            new Category{CatId=2,CatName="Cheese cakes",Desc="Cheesy All the way"},
            new Category{CatId=3,CatName="Seasonal pies",Desc="Get in the mood for seasonal Pie"},

        };
    }
}
