using proiect.Data;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities.Seeders
{
    public class StudentSeeder
    {
        public readonly ProiectContext _context;
        public StudentSeeder(ProiectContext context)
        {
            _context = context;
        }

        public void SeedInitialStudents()
        {
            if(!_context.Students.Any())
            {
                var student = new Student
                {
                    Name = "Student 1",
                    Age = 21,
                    IsDeleted = false
                };
                _context.Add(student);
                _context.SaveChanges();
            }
        }
    }
}
