using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<User> GetActive(this IQueryable<User> entities)
        {
            return entities.Where(x => x.IsDeleted == false);
        }
    }
}
