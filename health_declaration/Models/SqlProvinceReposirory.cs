using System;
using System.Collections.Generic;

namespace health_declaration.Models
{
    public class SqlProvinceReposirory : IProvinceRepository
    {
        private readonly AppDbContext context;
        public SqlProvinceReposirory(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Province> Gets()
        {
            return context.provinces;
        }
    }
}
