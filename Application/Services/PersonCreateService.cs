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
        public async Task<(PhysicalPersonModel, AccountModel, CardModel)> CreatePersonAsync(PersonCreateDto personCreateDto)
        {
            var user = new PhysicalPersonModel 
            {
                FirstName = personCreateDto.FirstName,
                LastName = personCreateDto.LastName,
                

                //Email = registerDto.Email,
                //Name = registerDto.Name,
                //Lastname = registerDto.Lastname,
                //BirthDate = registerDto.BirthDate,
                //IdNumber = registerDto.IdNumber
            };
            var account = new AccountModel
            {
                AccountNumber = personCreateDto.AccountNumber,
                Balance = personCreateDto.Balance,
                
            };
            var card = new CardModel
            {
                CardNumber = personCreateDto.CardNumber,
                Pin = personCreateDto.Pin,
            };


            return (user, account, card);
        }

    }
}
