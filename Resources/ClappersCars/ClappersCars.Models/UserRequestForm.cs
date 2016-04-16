using System;

namespace ClappersCars.Models
{
    public class UserRequestForm
    {
        public int UserRequestFormID { get; set; }
        public int VehicleID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public BestTime BestTimeToCall { get; set; }
        public ContactMethod PreferredContactMethod { get; set; }
        public DateTime TimeframeToPurchaseStart { get; set; }
        public DateTime TimeframeToPurchaseEnd { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime LastContactDate { get; set; }
        public ResponseStatus StatusOfRequest { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}