﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.ManyToMany
{
    public class ModelsRelation
    {
        public Guid Model3Id { get; set; }
        public Model3 Model3 { get; set; }
        public Guid Model4Id { get; set; }
        public Model4 Model4 { get; set; }
    }
}
