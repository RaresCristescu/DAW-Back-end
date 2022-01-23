using proiect.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
    }
}
