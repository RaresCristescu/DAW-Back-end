using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class Categorie:BaseEntity
    {
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public ICollection<Produs> Produss { get; set; }
    }
}
