using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiect.Models;
using proiect.Models.DTOs;
using proiect.Services.CategorieServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly ICategorieService _categorieService;
        public CategorieController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }
        [HttpGet("readByName")]
        public IActionResult GetByCodPostal(string name)
        {
            var result = _categorieService.GetDataMappedByName(name);
            return Ok(result);
        }
        [HttpGet("readById")]
        public IActionResult GetById(Guid id)
        {
            var result = _categorieService.GetDataMappedById(id);
            return Ok(result);
        }
        [HttpPost("create")]
        public IActionResult Create(CategorieRequestDTO categorie)
        {
            var categorieToCreate = new Categorie
            {
                Nume = categorie.Nume,
                Descriere = categorie.Descriere,
            };
            var result = _categorieService.PostDataMappedByName(categorieToCreate);
            return Ok(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Guid categorieId, CategorieRequestDTO categorie)
        {
            var categorieNew = new Categorie
            {
                Nume=categorie.Nume,
                Descriere=categorie.Descriere
            };
            var result = _categorieService.PutDataMappedById(categorieId, categorieNew);

            return Ok(result);
        }
        [HttpDelete("deleteById")]
        public IActionResult Delete(Guid categorieId)
        {
            var result = _categorieService.DeleteDataMappedById(categorieId);
            return Ok(result);
        }

    }
}
