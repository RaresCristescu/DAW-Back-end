using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.DTOs
{
    public class ProdusRequestDTO
    {
        //public Guid Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public string Imagine { get; set; }
        public float Pret { get; set; }
        public Guid CategorieId { get; set; }
    }
}
