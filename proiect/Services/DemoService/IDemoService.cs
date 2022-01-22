using proiect.Models.DTOs;
using proiect.Models.Relations.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.DemoService
{
    public interface IDemoService
    {
        ModelResultDTO GetDataMappedByTitle(string title);
    }
}
