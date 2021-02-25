using System.Collections.Generic;
using _portfolio.Data;
using _portfolio.Data.interfaces;
using _portfolio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace _portfolio.Data.Repository
{
    public class DiplomaRepository : IDiplomas
    {
        private readonly DatabaseContext databaseContext;

        public DiplomaRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IEnumerable<Diplomas> AllDiplomas => databaseContext.Diplomas;
    }
}