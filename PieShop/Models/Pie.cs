using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string AllergyInfo { get; set; }
        public decimal Price { get; set; }
        public string ImgURL { get; set; }
        public string ImgThumURL { get; set; }
        public bool IsPieOfWeek { get; set; }
        public bool InStock { get; set; }
        public int CatId { get; set; }
        public Category Category { get; set; }
        public string Notes { get; set; }

    }
}
