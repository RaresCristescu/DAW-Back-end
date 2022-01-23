using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<Student> GetActive(this IQueryable<Student> entities)
        {
            return entities.Where(x => x.IsDeleted == false);
        }
    }
}
