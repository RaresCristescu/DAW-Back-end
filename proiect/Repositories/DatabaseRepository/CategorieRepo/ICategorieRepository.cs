using proiect.Models;
using proiect.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository.CategorieRepo
{
    public interface ICategorieRepository:IGenericRepository<Categorie>
    {
        Categorie GetByName(string name);
        Categorie GetByNameIncludingProdus(string name);
        Categorie PostCategorie(Categorie categorie);
        Categorie PutCategorie(Guid catId, Categorie categorie);
        Categorie DeleteAddress(Guid catId);
        List<Categorie> GetAllWithInclude();
        List<Categorie> GetAllWithJoin();
    }
}
