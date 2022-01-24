using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.CategorieRepo
{
    public class CategorieRepository : GenericRepository<Categorie>, ICategorieRepository
    {
        public CategorieRepository(ProiectContext context) : base(context)
        {

        }

        public Categorie DeleteAddress(Guid catId)
        {
            throw new NotImplementedException();
        }

        public List<Categorie> GetAllWithInclude()
        {
            return _table.Include(x => x.Produss).ToList();
        }
        public async Task<List<Categorie>> GetAllWithIncludeAsync()
        {
            return await _table.Include(x => x.Produss).ToListAsync();
        }

        public List<Categorie> GetAllWithJoin()
        {
            var result = _table.Join(_context.Produss, adres => adres.Id, usr => usr.CategorieId, (adres, usr) => new { adres, usr }).Select(obj => obj.adres);
            return result.ToList();
        }

        public Categorie GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Categorie GetByNameIncludingProdus(string name)
        {
            throw new NotImplementedException();
        }

        public Categorie PostCategorie(Categorie categorie)
        {
            throw new NotImplementedException();
        }

        public Categorie PutCategorie(Guid catId, Categorie categorie)
        {
            throw new NotImplementedException();
        }
    }
}
