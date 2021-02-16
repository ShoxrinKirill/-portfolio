using System;
using System.Linq;
using _portfolio.Data.Models;
using System.Collections.Generic;

namespace _portfolio.Data.interfaces
{
    public interface IExamples
    {
        IEnumerable<Example> AllExamples {get;}
    }
}