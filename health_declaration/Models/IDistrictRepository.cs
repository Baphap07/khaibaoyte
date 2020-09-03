using System;
using System.Collections.Generic;

namespace health_declaration.Models
{
    public interface IDistrictRepository
    {
        IEnumerable<District> Gets();
        IEnumerable<District> GetsByProvinceId(int provinceId);
    }
}
