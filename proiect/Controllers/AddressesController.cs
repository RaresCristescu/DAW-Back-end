using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiect.Data;
using proiect.Models;
using proiect.Models.DTOs;
using proiect.Services.AddressService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        //private readonly ProiectContext _context;
        //public AddressesController(ProiectContext context)
        //{
        //    _context = context;
        //}
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _context.Addresses.ToListAsync());
        //}

        private readonly IAddressService _addressService;
        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet("readByCodPostal")]
        public IActionResult GetByCodPostal(string codPostal)
        {
            var result = _addressService.GetDataMappedByCodPostal(codPostal);
            return Ok(result);
        }
        [HttpGet("readByLocalitate")]
        public IActionResult GetByLocalitate(string codPostal)
        {
            var result = _addressService.GetDataMappedByLocalitate(codPostal);
            return Ok(result);
        }

        [HttpPost("create")]
        public IActionResult Create(AddressRequestDTO address)
        {
            var addressToCreate = new Models.Address
            {
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate=address.Localitate,
                CodPostal=address.CodPostal
                //BcryptNet.HashPassword(user.Password)
            };
            var result = _addressService.PostDataMappedByLocalitate(addressToCreate);
            return Ok(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Guid addressId, AddressRequestDTO address)
        {
            //var userIndex = _addressService.FindIndex((User _user) => _user.Id.Equals(user.Id));
            var addressNew = new Models.Address
            {
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate = address.Localitate,
                CodPostal = address.CodPostal
            };



            var result = _addressService.PutDataMappedById(addressId,addressNew);


            //    FindIndex((User _user) => _user.Id.Equals(user.Id));
            //users[userIndex] = user;
            return Ok(result);
        }

        [HttpDelete("deleteById")]
        public IActionResult Delete(Guid addressId)
        {
            var result = _addressService.DeleteDataMappedById(addressId);
            return Ok(result);
        }

    }
}
