using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PersonCreateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //i SHould insert all information here, information on account and card as well. anu aq vwer yelafers, da mere aq chawerili dauesaigndeba iqit 
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set; }

    }
}
