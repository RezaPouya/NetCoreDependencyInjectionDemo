using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Entities
{
    public class Person : BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
