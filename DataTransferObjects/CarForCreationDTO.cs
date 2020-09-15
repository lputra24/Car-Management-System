using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.DataTransferObjects
{
    public class CarForCreationDTO
    {
        public int VehicleTypeId { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public String Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public String BodyType { get; set; }
    }
}
