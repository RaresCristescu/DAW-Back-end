using proiect.Data;
using proiect.Models;
using proiect.Models.DTOs;
using proiect.Utilities;
using proiect.Utilities.JWTUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services
{
    public class UserService :IUserService
    {
        public ProiectContext _proiectContext;
        private IJWTUtils _iJWTUtils;
        private readonly AppSettings _appSettings;

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _proiectContext.Users.FirstOrDefault(x => x.UserName == model.UserName);

            if (user==null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {//!BCryptNet.Verify(model.Password, user.PasswordHash)
                return null;
            }
            //JWT generation
            var jwtToken = _iJWTUtils.GenerateJWTToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
