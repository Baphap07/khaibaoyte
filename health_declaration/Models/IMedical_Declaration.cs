using System;
using System.Collections.Generic;
using System.Linq;

namespace health_declaration.Models
{
    public interface IMedical_Declaration
    {
        Medical_Declaration Create(Medical_Declaration medical);
        IEnumerable<Medical_Declaration> Gets();
    }
}
