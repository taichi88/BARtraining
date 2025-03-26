using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Application.IServices
{
    public interface IPersonCreateService
    {
        Task<PhysicalPersonModel> CreatePersonAsync(PersonCreateDto personCreateDto);
    }
}
