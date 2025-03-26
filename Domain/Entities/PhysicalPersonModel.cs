using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Phisycal person model 
namespace Domain.Entities
{
    public class PhysicalPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
