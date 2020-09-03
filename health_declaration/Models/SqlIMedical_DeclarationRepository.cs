using System;
using System.Collections.Generic;
using System.Linq;

namespace health_declaration.Models
{
    public class SqlIMedical_DeclarationRepository:IMedical_Declaration
    {
        private readonly AppDbContext context;

        public SqlIMedical_DeclarationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Medical_Declaration Create(Medical_Declaration medical)
        {
            context.medicals.Add(medical);
            context.SaveChanges();
            return medical;
        }

        public IEnumerable<Medical_Declaration> Gets()
        {
            try
            {
                return context.medicals.ToList();

            }
            catch (Exception ex)
            { 
                return new List<Medical_Declaration>();
            }
            
        }
    }
}
