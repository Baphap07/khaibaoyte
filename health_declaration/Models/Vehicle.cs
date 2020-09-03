using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        public string VehicleName { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public DateTime Departureday { get; set; }
        [Required]
        public string Departure_location { get; set; }
        [Required]
        public string Destinetion { get; set; }

    }
}
