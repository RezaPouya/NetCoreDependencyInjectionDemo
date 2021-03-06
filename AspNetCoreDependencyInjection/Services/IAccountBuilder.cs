﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public interface IAccountBuilder
    {
        public void WithAccountType(AccountType type);
        public IAccount Build();
    }
}
