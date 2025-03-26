﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTOs;
using Application.IServices;

namespace BankATMSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonCreateService _personCreateService;

        public PersonController(IPersonCreateService personCreateService)
        {
            _personCreateService = personCreateService;
        }

    
        [HttpPost("CreatePerson")]
        public async Task<IActionResult> CreatePerson(PersonCreateDto personCreateDto)
        {
            var result = await _personCreateService.CreatePersonAsync(personCreateDto);
            Console.WriteLine(result);
            return Ok(result);
        }


    }

}
