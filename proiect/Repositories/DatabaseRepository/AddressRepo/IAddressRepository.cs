using proiect.Models;
using proiect.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.AddressRepo
{
    public interface IAddressRepository:IGenericRepository<Address>
    {
        Address GetByCodPostal(string title);
        Address GetByCodPostalIncludingUser(string title);
        Address GetByLocalitateIncludingUser(string localitate);
        Address PostAddress(Address address);
        Address PutAddress(Guid addId,Address address);

        Address DeleteAddress(Guid addressId);
        List<Address> GetAllWithInclude();
        List<Address> GetAllWithJoin();
    }
}
