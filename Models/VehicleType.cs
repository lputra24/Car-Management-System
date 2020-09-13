using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public class VehicleType
    {

        public int Id { get; set; }

        [Required(ErrorMessage= "Vehicle type is a required field")]
        [MaxLength(50, ErrorMessage ="You cannot exceed 50 characters for vehicle type field")]
        public String Type { get; set; }
    }
}
