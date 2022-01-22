using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.Models;
using proiect.Models.Base;
using proiect.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Repositories
{
    public class GenericRepository<TEntity>:IGenericRepository<TEntity> where TEntity:BaseEntity
    {
        protected readonly ProiectContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ProiectContext context)
        {
            _context=context;
            _table = _context.Set<TEntity>();
        }
        //Get All

        public async Task<List<TEntity>>GetAll()
        {
            //the select to the DB
            return await _table.AsNoTracking().ToListAsync();
        }

        public IQueryable<TEntity>GetAllAsQueryable()
        {
            return _table.AsNoTracking();
            //try not to use toList count etc, befor filtering the data
            /*var entityList = _table.ToList();
            var entityListFiltered = _table.Where(x=>x.Id.ToString()!="");*/

            //better version; the data is filtered in the query
            //select * from entity where id is not null
            /*var entityListFiltere = _table.Where(x=>x.Id.ToString()!="").ToList();*/
        }
        //Create
        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }
        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }
        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }
        //Update
        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }
        //Delete
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }
        //Find
        public TEntity FindById(object id)
        {
            return _table.Find(id);
            //another option
            //return _table.FirstOrDefault(x=>x.Equals(id));
        }
        public async Task<TEntity>FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
            //another option
            //return await _table.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        //Save
        public bool Save()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
    }
}
