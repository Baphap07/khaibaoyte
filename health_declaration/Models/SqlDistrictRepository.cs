using System;
using System.Collections.Generic;
using System.Linq;

namespace health_declaration.Models
{
    public class SqlDistrictRepository:IDistrictRepository
    {
        private readonly AppDbContext context;
        public SqlDistrictRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<District> Gets()
        {
            return context.districts;
        }

        public IEnumerable<District> GetsByProvinceId(int provinceId)
        {
            List<District> districts = (from d in context.districts where d.ProvinceId == provinceId select d).ToList();
            return districts;
        }
    }
}
