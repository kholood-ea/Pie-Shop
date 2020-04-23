using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
   public interface IPieRepo
    {
        IEnumerable<Pie> AllPies { get;}
        IEnumerable<Pie> PiesOfWeek { get; }

        Pie GetPieById(int pieId);


    }
}
