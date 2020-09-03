using System;
using System.Collections.Generic;

namespace health_declaration.Models
{
    public class SqlGateRepository:IGateRepository
    {
        private readonly AppDbContext context;
        public SqlGateRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Gate> Gets()
        {
            return context.gates;
        }
    }
}
