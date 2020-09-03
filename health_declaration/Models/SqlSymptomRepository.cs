using System;
namespace health_declaration.Models
{
    public class SqlSymptomRepository:ISymptomRepository
    {
        private readonly AppDbContext context;

        public SqlSymptomRepository(AppDbContext context)
        {
            this.context = context;
        }

        public int Create(Symptom symptom)
        {
            context.symptoms.Add(symptom);
            context.SaveChanges();
            return symptom.SymptomId;
        }
    }
}
