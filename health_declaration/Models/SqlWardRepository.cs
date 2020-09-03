using System;
using System.Linq;
using System.Collections.Generic;
using health_declaration.ViewModels;

namespace health_declaration.Models
{
    public class SqlWardRepository:IWardRepository
    {
        private readonly AppDbContext context;
        public SqlWardRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Ward> Gets()
        {
            return context.wards;
        }

        public IEnumerable<Ward> GetsByDistrictId(RequestsWard requestsWard)
        {
            List<Ward> wards = (from w in context.wards where (w.DistrictId == requestsWard.DistrictId && w.ProvinceId==requestsWard.ProvinceId  ) select w).ToList();
            return wards;
        }
    }
}
