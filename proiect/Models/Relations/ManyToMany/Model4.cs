using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.ManyToMany
{
    public class Model4:BaseEntity
    {
        public string Title { get; set; }
       // public ICollection<Model3> Models3 { get; set; }
       public ICollection<ModelsRelation> ModelRelations { get; set; }
    }
}
