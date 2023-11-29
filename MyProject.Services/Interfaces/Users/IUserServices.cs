using MyProject.Domain.Entities;
using MyProject.Services.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces.Users
{
    public interface IUserServices
    {
        Task AddAsync(UserDto dto);
        Task<User> GetById(Guid id);
    }
}
