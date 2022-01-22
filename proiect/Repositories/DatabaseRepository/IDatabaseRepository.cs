using proiect.Models.Relations.OneToMany;
using proiect.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository
{
    public interface IDatabaseRepository: IGenericRepository<Model1>
    {
        Model1 GetByTitle(string title);
        Model1 GetByTitleIncludingModel2(string title);
        List<Model1> GetAllWithInclude();
        List<Model1> GetAllWithJoin();
    }
}
