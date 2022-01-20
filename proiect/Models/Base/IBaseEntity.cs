using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateCreated { get; set; }//"?" inseamna ca poate fi si null, e nullable
        DateTime? DateModified { get; set; }

    }
}
