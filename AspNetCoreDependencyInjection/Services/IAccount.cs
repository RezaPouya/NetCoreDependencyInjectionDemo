using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public interface IAccount
    {
        public AccountType Type { get; }
        public long InitialBalance { get; }
    }


    public enum AccountType
    {
        Viewer = 0 , 
        Guest = 1,
        Bronze = 2 , 
        Silver = 3 , 
        Gold = 4 , 
        Platinum = 5 , 
        Titanium = 6 , 
    }
}
