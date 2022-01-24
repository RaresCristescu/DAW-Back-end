using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class DetaliiComanda:BaseEntity
    {
        public int Cantitate { get; set; }

        public Guid ComandaId { get; set; }
        public Comanda Comanda { get; set; }
        public Guid ProdusId { get; set; }
        public Produs Produs { get; set; }
    }
}
