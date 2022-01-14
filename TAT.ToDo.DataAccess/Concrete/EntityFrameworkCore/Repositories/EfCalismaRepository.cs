using System;
using System.Collections.Generic;
using System.Linq;
using TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using TAT.ToDo.DataAccess.Interfaces;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : EfGenericRepository<Calisma>,ICalismaDal
    {
        
    }
}
