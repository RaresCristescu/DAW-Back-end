using proiect.Models;
using proiect.Models.DTOs;
using proiect.Repositories.DatabaseRepository.CategorieRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.CategorieServ
{
    public class CategorieService : ICategorieService
    {
        public ICategorieRepository _categorieRepository;

        public CategorieService(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        public CategorieRequestDTO GetDataMappedByName(string name)
        {
            Categorie categorie = _categorieRepository.GetByNameIncludingProdus(name);
            CategorieRequestDTO result = new()
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            return result;
        }
        public CategorieRequestDTO PostDataMappedByName(Categorie _categorie)
        {
            Categorie categorie = _categorieRepository.PostCategorie(_categorie);
            CategorieRequestDTO result = new()
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            return result;
        }

        public CategorieRequestDTO PutDataMappedById(Guid categorieId, Categorie _categorie)
        {
            Categorie categorie = _categorieRepository.PutCategorie(categorieId,_categorie);
            CategorieRequestDTO result = new()
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            return result;
        }
        public CategorieRequestDTO DeleteDataMappedById(Guid categorieId)
        {
            Categorie categorie = _categorieRepository.DeleteCategorie(categorieId);
            CategorieRequestDTO result = new()
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            return result;
        }

        public CategorieRequestDTO GetDataMappedById(Guid id)
        {
            Categorie categorie = _categorieRepository.GetByIdIncludingProdus(id);
            CategorieRequestDTO result = new()
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            return result;
        }
    }
}
