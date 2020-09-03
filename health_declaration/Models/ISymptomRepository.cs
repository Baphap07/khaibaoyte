using System;
namespace health_declaration.Models
{
    public interface ISymptomRepository
    {
        int Create(Symptom symptom);
    }
}
