using System;
using System.ComponentModel.DataAnnotations;

namespace ClappersCars.Models
{
    public class UserRequestForm
    {
        public int UserRequestFormID { get; set; }
        public int VehicleID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public BestTime BestTimeToCall { get; set; }
        public ContactMethod PreferredContactMethod { get; set; }

        [DataType(DataType.Date)]
        public DateTime TimeframeToPurchaseStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime TimeframeToPurchaseEnd { get; set; }

        public string AdditionalInformation { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastContactDate { get; set; }

        public ResponseStatus StatusOfRequest { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}