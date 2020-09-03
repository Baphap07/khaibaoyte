using System;
using System.Collections.Generic;
using health_declaration.ViewModels;

namespace health_declaration.Models
{
    public interface IWardRepository
    {
        IEnumerable<Ward> Gets();
        IEnumerable<Ward> GetsByDistrictId(RequestsWard requestsWard);
    }
}
