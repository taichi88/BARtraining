using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace BankATMSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPost("CreatePerson")]
        public async Task CreatePersonasync(PhysicalPersonModel PhysicalPersonModel)
        {
            throw new NotImplementedException();
        }


    }
}
