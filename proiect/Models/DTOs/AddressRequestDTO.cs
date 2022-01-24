using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.DTOs
{
    public class AddressRequestDTO
    {
        public string Strada { get; set; }
        public string Judet { get; set; }
        public string Localitate { get; set; }
        public string CodPostal { get; set; }
    }
}
