using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.AddressRepo
{
    public class AddressRepository: GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ProiectContext context) : base(context)
        {

        }
        public List<Address> GetAllWithInclude() 
        {
            return _table.Include(x => x.Users).ToList();
        }
        public async Task<List<Address>> GetAllWithIncludeAsync()
        {
            return await _table.Include(x => x.Users).ToListAsync();
        }
        public List<Address> GetAllWithJoin()
        {
            var result = _table.Join(_context.Users, adres => adres.Id, usr => usr.AddressId, (adres, usr) => new { adres, usr }).Select(obj=>obj.adres);
            return result.ToList();

        }
        public async Task<List<Address>> GetAllWithJoinAsync()
        {
            var result = _table.Join(_context.Users, model1 => model1.Id, model2 => model2.AddressId, (model1, model2) => new { model1, model2 }).Select(obj => obj.model1);
            return await result.ToListAsync();

        }
        public Address GetByCodPostal(string codPostal)
        {
            return _table.FirstOrDefault(x => x.CodPostal.ToLower().Equals(codPostal.ToLower()));
        }
        public async Task<Address> GetByCodPostalAsync(string codPostal)
        {
            return await _table.FirstOrDefaultAsync(x => x.CodPostal.ToLower().Equals(codPostal.ToLower()));
        }
        public Address GetByCodPostalIncludingUser(string codPostal)
        {
            return _table.Include(x => x.Users).FirstOrDefault(x => x.CodPostal.ToLower().Equals(codPostal.ToLower()));
        }

        public Address GetByLocalitateIncludingUser(string localitate)
        {
            return _table.Include(x => x.Users).FirstOrDefault(x => x.Localitate.ToLower().Equals(localitate.ToLower()));
        }

        public Address PostAddress(Address address)
        {
            _context.Add<Address>(address);
            _context.SaveChanges();

            return address;
        }
        public Address PutAddress(Guid addId,Address address)
        {
            Address adr=_table.Where(x => x.Id == addId).Single<Address>();
            adr.Judet = address.Judet;
            adr.Localitate = address.Localitate;
            adr.Strada = address.Strada;
            adr.CodPostal = address.CodPostal;
            _context.Update(adr);
            _context.SaveChanges();

            return adr;
        }

        public Address DeleteAddress(Guid addressId)
        {
            Address adr = _table.Where(x => x.Id == addressId).Single<Address>();
            _context.Remove<Address>(adr);
            _context.SaveChanges();
            return adr;
        }

        public Address WhereWithLinqQuerySyntaz(string localitate)
        {
            var result = from n1 in _table
                         where n1.Localitate == localitate
                         select n1;
            //var result2 = _table.Where(x => x.Order > 1);// alta varianta

            //return result2.FirstOrDefault();//alta varianta
            return result.FirstOrDefault();
        }
    }
}
