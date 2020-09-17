using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public interface IVehicle
    {
        int Id { get; set; }

        VehicleType VehicleType { get; set; }

        String Make { get; set; }

        String Model { get; set; }

        String BodyType { get; set; }
    }
}
