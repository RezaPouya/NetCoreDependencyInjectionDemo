using AspNetCoreDependencyInjection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public class PersonRepository : BaseRepository<Person> , IPersonRepository
    {
    }
}
