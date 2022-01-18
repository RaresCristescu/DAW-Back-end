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

    }
}
