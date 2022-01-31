using proiect.Models;
using proiect.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.ProdusRepo
{
    public interface IProdusRepository:IGenericRepository<Produs>
    {
        Produs GetByTitlu(string title);
        Produs GetByTitluIncludingDetaliiComanda(string title);
        Produs GetByIdIncludingDetaliiComanda(Guid id);
        Produs PostProdus( Produs produs);
        Produs PutProdus(Guid addId, Produs produs);
        Produs DeleteProdus(Guid produsId);
        List<Produs> GetAllWithInclude();
        List<Produs> GetAllWithJoin();
    }
}
