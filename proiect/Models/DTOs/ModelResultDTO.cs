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
        public Guid Model1Id { get; set; }
        public List<Model2> Models2 { get; set; }

    }
}
