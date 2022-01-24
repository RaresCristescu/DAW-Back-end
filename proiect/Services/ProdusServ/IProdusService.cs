using proiect.Models;
using proiect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.ProdusServ
{
    public interface IProdusService
    {
        ProdusRequestDTO GetDataMappedByTitlu(string titlu);
        ProdusRequestDTO PostDataMappedByTitlu(Produs _produs);
        //AddressRequestDTO PutDataMappedByLocalitate(Address _address);
        ProdusRequestDTO PutDataMappedById(Guid produsId, Produs _produs);
        ProdusRequestDTO DeleteDataMappedById(Guid produsId);
    }
}
