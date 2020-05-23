using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity 
    {
    }
}
