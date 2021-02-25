using System.Collections.Generic;
using _portfolio.Data.Models;

namespace _portfolio.Data.interfaces
{
    public interface IDiplomas
    {
         IEnumerable<Diplomas> AllDiplomas {get;}
    }
}