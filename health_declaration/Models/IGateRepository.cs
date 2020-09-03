using System;
using System.Collections.Generic;

namespace health_declaration.Models
{
    public interface IGateRepository
    {
        IEnumerable<Gate> Gets();
    }
}
