using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class Produs:BaseEntity
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public string Imagine { get; set; }
        public float Pret { get; set; }
        public Categorie Categorie { get; set; }
        public Guid CategorieId { get; set; }
        public ICollection<DetaliiComanda> DetaliiComandas { get; set; }
    }
}
