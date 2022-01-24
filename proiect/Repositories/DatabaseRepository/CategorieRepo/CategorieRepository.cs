using Microsoft.AspNetCore.Mvc;
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
        public async Task<List<Categorie>> GetAllWithJoinAsync()
        {
            var result = _table.Join(_context.Produss, adres => adres.Id, usr => usr.CategorieId, (adres, usr) => new { adres, usr }).Select(obj => obj.adres);
            return await result.ToListAsync();

        }
        public Categorie GetByName(string name)
        {
            return _table.FirstOrDefault(x => x.Nume.ToLower().Equals(name.ToLower()));
        }
        //public async Task<Categorie> GetByNameAsync(string name)
        //{
        //    return await _table.FirstOrDefault(x => x.Nume.ToLower().Equals(name.ToLower()));
        //}
        public Categorie GetByNameIncludingProdus(string name)
        {
            return _table.Include(x => x.Produss).FirstOrDefault(x => x.Nume.ToLower().Equals(name.ToLower()));

        }

        public Categorie PostCategorie(Categorie categorie)
        {
            _context.Add<Categorie>(categorie);
            _context.SaveChanges();

            return categorie;
        }

        public Categorie PutCategorie(Guid catId, Categorie categorie)
        {
            Categorie ctg = _table.Where(x => x.Id == catId).Single<Categorie>();
            ctg.Nume = categorie.Nume;
            ctg.Descriere = categorie.Descriere;
            _context.Update(ctg);
            _context.SaveChanges();

            return ctg;
        }

        public Categorie DeleteCategorie(Guid catId)
        {
            Categorie ctg = _table.Where(x => x.Id == catId).Single<Categorie>();
            _context.Remove<Categorie>(ctg);
            _context.SaveChanges();
            return ctg;
        }
        public Categorie WhereWithLinqQuerySyntaz(string name)
        {
            var result = from n1 in _table
                         where n1.Nume == name
                         select n1;
            //var result2 = _table.Where(x => x.Order > 1);// alta varianta

            //return result2.FirstOrDefault();//alta varianta
            return result.FirstOrDefault();
        }
    }
}
