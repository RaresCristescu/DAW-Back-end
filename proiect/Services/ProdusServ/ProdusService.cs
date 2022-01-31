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
                //Id=produs.Id,
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId=produs.CategorieId
            };
            return result;
        }

        public List<ProdusRequestDTO> GetAllDataMapped()
        {
            List<Produs> produse = _produsRepository.GetAllWithInclude();
            //
            List<ProdusRequestDTO> results = new List<ProdusRequestDTO>();
            //produse.ForEach(pro => results.Add(pro));
            for (int i = 0; i < produse.Count; i++)
            {
                results.Add(new()
                {
                    //Id=produs.Id,
                    Titlu = produse[i].Titlu,
                    Descriere = produse[i].Descriere,
                    Imagine = produse[i].Imagine,
                    Pret = produse[i].Pret,
                    CategorieId = produse[i].CategorieId
                });
            }

            return results;
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

        public ProdusRequestDTO GetDataMappedById(Guid id)
        {
            Produs produs = _produsRepository.GetByIdIncludingDetaliiComanda(id);
            ProdusRequestDTO result = new()
            {
                //Id=produs.Id,
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
