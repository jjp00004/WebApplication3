using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Officer
    {
        public int OfficerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string DOB { get; set; }

        public string DriversLicenseNum { get; set; }
    }
}
