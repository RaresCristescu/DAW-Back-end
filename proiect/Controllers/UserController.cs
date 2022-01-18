using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = new List<User>
        {
            new User {Id=1,Name="Rares",UserName="admin",Email="admin@gmail.com",Telefon="0734951510"},
            new User {Id=2,Name="Vasile",UserName="vsl",Email="vasile@gmail.com" ,Telefon="0734998510"},
            new User {Id=3,Name="Luca",UserName="luk",Email="luk69@gmail.com",Telefon="0732251510" }
        };
        [HttpGet("getUsers")]
        public List<User> Get()
        {
            return users;
        }
        [HttpGet("byId/{id}")]
        public User GetUserByIp(int id)
        {
            return users.FirstOrDefault(s => s.Id.Equals(id));
        }
        [HttpGet("filter/{name}/{telefon}")]
        public User GetWithFilter(string name, string telefon)
        {
            return users.FirstOrDefault(x => x.Name.Equals(name) && x.Telefon.Equals(telefon));
        }
        [HttpGet("byIdFromHeader")]
        public User GetUserIdFromHeader([FromHeader]int id)
        {
            return users.FirstOrDefault(s => s.Id.Equals(id));
        }
        [HttpGet("byIdFromQuery")]
        public User GetUserByidFromQuery([FromQuery]int id)
        {
            return users.FirstOrDefault(s => s.Id.Equals(id));
        }
        [HttpGet("byIdFromQueryWithFiltre")]
        public User GetUserByidFromQueryWithFiltre([FromQuery] int id,[FromQuery]string telefon)
        {
            return users.FirstOrDefault(s => s.Id.Equals(id) && s.Telefon.Equals(telefon));
        }

        [HttpPost("AddUser")]
        public IActionResult Add(User user)
        {
            users.Add(user);

            //return NotFound();
            //return Forbid();

            return Ok(users);
        }
        [HttpPost("addUserFromHeader")]
        public IActionResult AddUserFromHeader([FromHeader]User user)//cica nu merge sa dia post din header
        {
            users.Add(user);
            return Ok(users);
        }

        [HttpPost("addUserFromForm")]
        public IActionResult AddUserFromForm([FromForm] User user)
        {
            users.Add(user);
            return Ok(users);
        }
        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            var userIndex = users.FindIndex((User _user) => _user.Id.Equals(user.Id));
            users[userIndex] = user;
            return Ok(users);
        }
        [HttpDelete]
        public IActionResult Delete(User user)
        {
            users.Remove(user);
            return Ok(users);
        }
    }
}
