using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class Account : IAccount
    {
        public Account(AccountType type, long initialBalance)
        {
            Type = type;
            InitialBalance = initialBalance;
        }

        public AccountType Type { get; private set; }
        public long InitialBalance { get; private set; }
    }
}
