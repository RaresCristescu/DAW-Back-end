﻿using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Relations.OneToOne
{
    public class Model6:BaseEntity
    {
        public string Name { get; set; }
        public Model5 Model5 { get; set; }

        public Guid Model5Id { get; set; }
    }
}
