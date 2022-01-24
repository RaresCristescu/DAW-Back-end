using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class Comanda:BaseEntity
    {
        public float PretTotal { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<DetaliiComanda> DetaliiComandas { get; set; }
    }
}
