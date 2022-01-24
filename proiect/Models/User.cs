using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class User:BaseEntity
    {
        
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }
        public Guid AddressId { get; set; }

        public ICollection<Comanda> Comandas { get; set; }//Comandas :)))))

        //[StringLength(11)]
        //public string Telefon { get; set; }

        /*public string Parola { get; set; }
        
        public string Rol { get; set; }
        public string id_Adresa { get; set; }*/
    }
}
