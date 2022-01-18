using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [StringLength(11)]
        public string Telefon { get; set; }
        /*public string Parola { get; set; }
        
        public string Rol { get; set; }
        public string id_Adresa { get; set; }*/
    }
}
