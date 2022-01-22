using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;
using proiect.Models.Relations.OneToMany;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories.DatabaseRepository
{
    public class DatabaseRepository:GenericRepository<Model1>, IDatabaseRepository
    {
        public DatabaseRepository(ProiectContext context): base(context)
        {

        }

        public List<Model1> GetAllWithInclude()
        {
            return _table.Include(x => x.Models2).ToList();
        }
        public async Task<List<Model1>> GetAllWithIncludeAsync()
        {
            return await _table.Include(x => x.Models2).ToListAsync();
            //model1 model1-a
            //  model2 model2-a
            //model1 model1-b
            //  model2 model2-b

            //{... model1-a,..., ,{...model2-a,...}},{... model1-b,{...model2-b}}
        }


        public List<Model1> GetAllWithJoin()
        {
            var result = _table.Join(_context.Models2, model1 => model1.Id, model2 => model2.Model1Id, (model1, model2) => new { model1, model2 }).Select(obj=>obj.model1);
            //model1, model2
            
            //{... model1-a,...,model2-a,...}, {...model1-b,...,model2-b,...}
            return result.ToList();
            
        }
        public async Task<List<Model1>> GetAllWithJoinAsync()
        {
            var result = _table.Join(_context.Models2, model1 => model1.Id, model2 => model2.Model1Id, (model1, model2) => new { model1, model2 }).Select(obj => obj.model1);
            return await result.ToListAsync();

        }
        public Model1 GetByTitle(string title)
        {
            return _table.FirstOrDefault(x => x.Title.ToLower().Equals(title.ToLower()));
        }
        public async Task<Model1> GetByTitleAsync(string title)
        {
            return await _table.FirstOrDefaultAsync(x => x.Title.ToLower().Equals(title.ToLower()));
        }
        public Model1 GetByTitleIncludingModel2(string title)
        {
            return _table.Include(x=>x.Models2).FirstOrDefault(x => x.Title.ToLower().Equals(title.ToLower()));
        }
        public Model1 WhereWithLinqQuerySyntaz(string title)
        {
            var result = from n1 in _table
                         where n1.Order > 1
                         select n1;
            //var result2 = _table.Where(x => x.Order > 1);// alta varianta

            //return result2.FirstOrDefault();//alta varianta
            return result.FirstOrDefault();
        }

    }
}
