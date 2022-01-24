using proiect.Models;
using proiect.Models.DTOs;
using proiect.Repositories.DatabaseRepository.AddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.AddressService
{
    public class AddressService:IAddressService
    {
        public IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
   
        AddressRequestDTO IAddressService.GetDataMappedByCodPostal(string codPostal)
        {
            Address address = _addressRepository.GetByCodPostalIncludingUser(codPostal);
            AddressRequestDTO result = new()
            {
                CodPostal = address.CodPostal,
                Strada=address.Strada,
                Judet=address.Judet,
                Localitate=address.Localitate
            };
            return result;
        }
        AddressRequestDTO IAddressService.GetDataMappedByLocalitate(string codPostal)
        {
            Address address = _addressRepository.GetByLocalitateIncludingUser(codPostal);
            AddressRequestDTO result = new()
            {
                CodPostal = address.CodPostal,
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate = address.Localitate
            };
            return result;
        }

        AddressRequestDTO IAddressService.PostDataMappedByLocalitate(Address _address)
        {
            Address address = _addressRepository.PostAddress(_address);
            AddressRequestDTO result = new()
            {
                CodPostal = address.CodPostal,
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate = address.Localitate
            };
            return result;
        }

        AddressRequestDTO IAddressService.PutDataMappedById(Guid addressId,Address _address)
        {
            Address address = _addressRepository.PutAddress(addressId,_address);
            AddressRequestDTO result = new()
            {
                CodPostal = address.CodPostal,
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate = address.Localitate
            };
            return result;
        }
        AddressRequestDTO IAddressService.DeleteDataMappedById(Guid addressId)
        {
            Address address = _addressRepository.DeleteAddress(addressId);
            AddressRequestDTO result = new()
            {
                CodPostal = address.CodPostal,
                Strada = address.Strada,
                Judet = address.Judet,
                Localitate = address.Localitate
            };
            return result;
        }
    }
}
