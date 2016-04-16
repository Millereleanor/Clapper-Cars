using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClappersCars.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Mileage { get; set; }
        public int AdTitle { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string UrlOfPicture { get; set; }
        public bool IsAvailable { get; set; }
        public bool Condition { get; set; }

        public virtual List<UserRequestForm> UserRequestForms { get; set; }
    }
}