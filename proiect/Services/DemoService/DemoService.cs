using proiect.Models.DTOs;
using proiect.Models.Relations.OneToMany;
using proiect.Repositories.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Services.DemoService
{
    public class DemoService : IDemoService
    {
        public IDatabaseRepository _databaseRepository;

        public DemoService(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }
        public ModelResultDTO GetDataMappedByTitle(string title)
        {
            Model1 model1 = _databaseRepository.GetByTitleIncludingModel2(title);
            ModelResultDTO result = new()
            {
                Title = model1.Title,
                Order = model1.Order,
                //Model1Id = model1.Id,
                //Models2 = (List<Model2>)model1.Models2
            };

            return result;
        }
    }
}
