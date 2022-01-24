using proiect.Models;
using proiect.Models.DTOs;
using proiect.Repositories.DatabaseRepository.ProdusRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.ProdusServ
{
    public class ProdusService : IProdusService
    {
        public IProdusRepository _produsRepository;
        public ProdusService(IProdusRepository produsRepository)
        {
            _produsRepository = produsRepository;
        }
        
        public ProdusRequestDTO GetDataMappedByTitlu(string titlu)
        {
            Produs produs = _produsRepository.GetByTitluIncludingDetaliiComanda(titlu);
            ProdusRequestDTO result = new()
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId=produs.CategorieId
            };
            return result;
        }

        public ProdusRequestDTO PostDataMappedByTitlu(Produs _produs)
        {
            Produs produs = _produsRepository.PostProdus(_produs);
            ProdusRequestDTO result = new()
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId = produs.CategorieId
            };
            return result;
        }

        public ProdusRequestDTO PutDataMappedById(Guid produsId, Produs _produs)
        {
            Produs produs = _produsRepository.PutProdus(produsId,_produs);
            ProdusRequestDTO result = new()
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId = produs.CategorieId
            };
            return result;
        }
        public ProdusRequestDTO DeleteDataMappedById(Guid produsId)
        {
            Produs produs = _produsRepository.DeleteProdus(produsId);
            ProdusRequestDTO result = new()
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId = produs.CategorieId
            };
            return result;
        }

    }
}
