using proiect.Models;
using proiect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.CategorieServ
{
    public interface ICategorieService
    {
        CategorieRequestDTO GetDataMappedByName(string name);
        CategorieRequestDTO GetDataMappedById(Guid id);
        CategorieRequestDTO PostDataMappedByName(Categorie _categorie);
        //AddressRequestDTO PutDataMappedByLocalitate(Address _address);
        CategorieRequestDTO PutDataMappedById(Guid categorieId, Categorie _categorie);
        CategorieRequestDTO DeleteDataMappedById(Guid categorieId);
    }
}
