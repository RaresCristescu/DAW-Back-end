using proiect.Models;
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
        AddressRequestDTO GetDataMappedByLocalitate(string codPostal);
        AddressRequestDTO GetDataMappedById(Guid id);
        AddressRequestDTO PostDataMappedByLocalitate(Address _address);
        //AddressRequestDTO PutDataMappedByLocalitate(Address _address);
        AddressRequestDTO PutDataMappedById(Guid addressId, Address _address);
        AddressRequestDTO DeleteDataMappedById(Guid addressId);
    }
}
