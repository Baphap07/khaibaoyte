using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Symptom
    {
        public int SymptomId { get; set; }
        [Required]
        public bool Fever { get; set; }
        [Required]
        public bool Cough { get; set; }
        [Required]
        public bool Sob { get; set; }
        [Required]
        public bool Sorethroat { get; set; }
        [Required]
        public bool Nausea { get; set; }
        [Required]
        public bool Diarhea { get; set; }
        [Required]
        public bool Bots { get; set; }
        [Required]
        public bool Skinrash { get; set; }
        [Required]
        public bool medical { get; set; }

    }
}

