using proiect.Models.Relations.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.DTOs
{
    public class ModelResultDTO
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid StudentId { get; set; }
        public string Password { get; set; }

    }
}
