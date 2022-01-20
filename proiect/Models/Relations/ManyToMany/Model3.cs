using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.ManyToMany
{
    public class Model3:BaseEntity
    {
        public string Title { get; set; }
        //public ICollection<Model4> Models4 { get; set; }
        public ICollection<ModelsRelation> ModelRelations { get; set; }
    }
}
