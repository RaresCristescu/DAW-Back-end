using proiect.Data;
using proiect.Models;
using proiect.Utilities.Extensions;
using System;
using System.Linq;

namespace proiect.Repositories.DatabaseRepository
{
    public class StudentRepository:GenericRepository<Student>//,IDatabaseRepository
    {
        public StudentRepository(ProiectContext context) :base(context)
        {

        }

        //OrderByAge
        public void OrderByAge()
        {
            //LINQ
            var studentOrderedAsc1 = _table.OrderBy(x => x.Age);
            var studentOrderedDesc1 = _table.OrderByDescending(x => x.Age);

            //LINQ Querry Syntax
            var studentsOrderedAsc2 = from s in _table
                                      orderby s.Age
                                      select s;
            var studentsOrderedDesc2 = from s in _table
                                      orderby s.Age descending
                                      select s;


        }
        public void OrderByAgeAndName()
        {
            var studentsOrderedAsc1 = _table.GetActive().OrderBy(x => x.Age).ThenBy(x => x.Name);
            var studentsOrderedDesc1 = _table.GetActive().OrderBy(x => x.Age).ThenByDescending(x => x.Name);
        }

        public void GroupBy()
        {
            var groupedStudents = from s in _table group s by s.Age;
            var groupedStudents1 = _table.GroupBy(x => x.Age);

            foreach(var studentGroupByAge in groupedStudents)
            {
                Console.WriteLine("Students group age: " + studentGroupByAge.Key);

                foreach(Student s in studentGroupByAge)
                {
                    Console.WriteLine("Student Name: " + s.Name);
                }
            }
        }

        //public Model1 GetByTitle(string title)
        //{
        //    throw new NotImplementedException();
        //}

        //public Model1 GetByTitleIncludingModel2(string title)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Model1> GetAllWithInclude()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Model1> GetAllWithJoin()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<List<Model1>> IGenericRepository<Model1>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //IQueryable<Model1> IGenericRepository<Model1>.GetAllAsQueryable()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Create(Model1 entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task CreateAsync(Model1 entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void CreateRange(IEnumerable<Model1> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task CreateRangeAsync(IEnumerable<Model1> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Model1 entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateRange(IEnumerable<Model1> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Model1 entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteRange(IEnumerable<Model1> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //Model1 IGenericRepository<Model1>.FindById(object id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Model1> IGenericRepository<Model1>.FindByIdAsync(object id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
