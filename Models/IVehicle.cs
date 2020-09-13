using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public interface IVehicle
    {
        public int Id { get; set; }

        public VehicleType VehicleType { get; set; }

        public String Make { get; set; }

        public String Model { get; set; }

        public String BodyType { get; set; }
    }
}
