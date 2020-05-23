using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{


    public interface IBaseRepository<TEntity> where TEntity : BaseEntity 
    {
    }
}
