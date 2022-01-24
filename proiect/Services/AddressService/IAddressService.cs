using proiect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.AddressService
{
    public interface IAddressService
    {
        AddressRequestDTO GetDataMappedByCodPostal(string codPostal);
    }
}
