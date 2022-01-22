using proiect.Models;
using proiect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services
{
    public interface IUserService
    {
        //auth
        UserResponseDTO Authenticate(UserRequestDTO model);
        //getall
        IEnumerable<User> GetAllUsers();

        //getbyid
        User GetById(Guid id);
    }
}
