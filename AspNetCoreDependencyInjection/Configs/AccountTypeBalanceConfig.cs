using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Configs
{
    public class AccountTypeBalanceConfig
    {
        public AccountTypeBalanceConfig(List<(AccountType, long)> accountTypeDictionary)
        {
            accountTypeDictionary = accountTypeDictionary.Distinct().ToList();

            KeyValue = new Dictionary<AccountType, long>();
            
            foreach (var item in accountTypeDictionary) {
                KeyValue.Add(item.Item1, item.Item2);
            }
        }

        public Dictionary<AccountType , long> KeyValue { get; set; }

        public  long GetValue(AccountType accountType)
        {
            return KeyValue.FirstOrDefault(p => p.Key == accountType).Value; 
        }
    }
}
