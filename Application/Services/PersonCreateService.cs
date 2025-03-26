using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.IServices;
using Domain.Entities;

namespace Application.Services
{
    public class PersonCreateService : IPersonCreateService
    {
        public async Task<PhysicalPersonModel> CreatePersonAsync(PersonCreateDto personCreateDto)
        {
            var user = new PhysicalPersonModel 
            {
                FirstName = personCreateDto.Name,
                //Email = registerDto.Email,
                //Name = registerDto.Name,
                //Lastname = registerDto.Lastname,
                //BirthDate = registerDto.BirthDate,
                //IdNumber = registerDto.IdNumber
            };
            return user;
        }

    }
}
