using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Car
    {
        public int VIN { get; set; }
        [PrimaryKey(nameof(VIN))]
        public string LicensePlate { get; set; }

        public string Make {  get; set; }

        public string Model { get; set; }

        public string Mileage { get; set; }

        public int OfficerID { get; set; }
        [ForeignKey("OfficerID")]
        public Officer? officer
        { get; set; }
    }
}
