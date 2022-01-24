using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiect.Data;
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
        [HttpGet("byCodPostal")]
        public IActionResult GetByCodPostal(string codPostal)
        {
            var result = _addressService.GetDataMappedByCodPostal(codPostal);
            return Ok(result);
        }
    }
}
