using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public class Car : IVehicle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("VehicleTypeId")]
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Make is a required field")]
        [MaxLength(50, ErrorMessage = "You cannot exceed 50 characters for Make field")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Model is a required field")]
        [MaxLength(50, ErrorMessage = "You cannot exceed 50 characters for Model field")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Engine is a required field")]
        [MaxLength(50, ErrorMessage = "You cannot exceed 50 characters for Engine field")]
        public String Engine { get; set; }

        [Required(ErrorMessage = "Make is a required field")]
        [Range(2, 10, ErrorMessage ="Can only be between 2 to 10")]
        public int Doors { get; set; }

        [Required(ErrorMessage = "Wheels is a required field")]
        [Range(2, 12, ErrorMessage = "Can only be between 2 to 12")]
        public int Wheels;

        [Required(ErrorMessage = "Body Type is a required field")]
        [MaxLength(50, ErrorMessage = "You cannot exceed 50 characters for Body Type field")]
        public string BodyType { get; set; }
    }
}
