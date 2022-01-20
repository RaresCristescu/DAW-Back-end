using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.OneToOne
{
    public class Model5: BaseEntity
    {
        public string Name { get; set; }
        public Model6 Model6 { get; set; }
        public Guid Model6Id { get; set; }
    }
}
