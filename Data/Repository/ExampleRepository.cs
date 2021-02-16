using System.Collections.Generic;
using _portfolio.Data;
using _portfolio.Data.interfaces;
using _portfolio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace _portfolio.Data.Repository
{
    public class ExampleRepository : IExamples
    {
        private readonly DatabaseContext databaseContext;

        public ExampleRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public IEnumerable<Example> AllExamples => databaseContext.Example;
    }
}