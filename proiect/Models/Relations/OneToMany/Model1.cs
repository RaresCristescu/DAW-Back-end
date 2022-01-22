using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.OneToMany
{
    public class Model1:BaseEntity
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public ICollection<Model2> Models2 { get; set; }
    }
}
