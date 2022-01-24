using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.ProdusRepo
{
    public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(ProiectContext context) : base(context)
        {

        }
        
        public List<Produs> GetAllWithInclude()
        {
            return _table.Include(x => x.DetaliiComandas).ToList();
        }
        public List<Produs> GetAllWithJoin()
        {
            var result = _table.Join(_context.DetaliiComandas, adres => adres.Id, usr => usr.ProdusId, (adres, usr) => new { adres, usr }).Select(obj => obj.adres);
            return result.ToList();
        }

        //public List<Produs> GetAllWithJoinAsync()
        //{
        //    var result = _table.Join(_context.DetaliiComandas, adres => adres.Id, usr => usr.ProdusId, (adres, usr) => new { adres, usr }).Select(obj => obj.adres);
        //    return await result.ToList();
        //}

        public Produs GetByTitlu(string title)
        {
            return _table.FirstOrDefault(x => x.Titlu.ToLower().Equals(title.ToLower()));
        }
        //public async Task<Produs> GetByTitluAsync(string title)
        //{
        //    return await _table.FirstOrDefault(x => x.Titlu.ToLower().Equals(title.ToLower()));
        //}

        public Produs GetByTitluIncludingDetaliiComanda(string title)
        {
            return _table.Include(x => x.DetaliiComandas).FirstOrDefault(x => x.Titlu.ToLower().Equals(title.ToLower()));
        }

        public Produs PostProdus(Produs produs)
        {
            _context.Add<Produs>(produs);
            _context.SaveChanges();

            return produs;
        }

        public Produs PutProdus(Guid addId, Produs produs)
        {
            Produs adr = _table.Where(x => x.Id == addId).Single<Produs>();
            adr.Titlu = produs.Titlu;
            adr.Descriere = produs.Descriere;
            adr.Imagine = produs.Imagine;
            adr.Pret = produs.Pret;
            _context.Update(adr);
            _context.SaveChanges();

            return adr;
        }
        public Produs DeleteProdus(Guid produsId)
        {
            Produs adr = _table.Where(x => x.Id == produsId).Single<Produs>();
            _context.Remove<Produs>(adr);
            _context.SaveChanges();
            return adr;
        }
        public Produs WhereWithLinqQuerySyntaz(string titlu)
        {
            var result = from n1 in _table
                         where n1.Titlu == titlu
                         select n1;
            //var result2 = _table.Where(x => x.Order > 1);// alta varianta

            //return result2.FirstOrDefault();//alta varianta
            return result.FirstOrDefault();
        }

    }
}
