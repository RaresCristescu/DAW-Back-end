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
        List<Address> GetAllWithInclude();
        List<Address> GetAllWithJoin();
    }
}
