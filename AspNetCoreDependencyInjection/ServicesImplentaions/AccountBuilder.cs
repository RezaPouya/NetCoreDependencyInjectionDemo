using AspNetCoreDependencyInjection.Configs;
using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class AccountBuilder : IAccountBuilder
    {
        private AccountTypeBalanceConfig _accountTypeBalanceConfig;

        private AccountType _accountType;

        public AccountBuilder(AccountTypeBalanceConfig accountTypeBalanceConfig)
        {
            _accountTypeBalanceConfig = accountTypeBalanceConfig;
        }

        public void WithAccountType(AccountType type) {
            _accountType = type;
        }

        public  IAccount Build()
        {
            switch (_accountType)
            {
                case AccountType.Viewer:  
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Viewer)) ;

                case AccountType.Guest:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Guest));

                case AccountType.Bronze:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Bronze));

                case AccountType.Silver:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Silver));

                case AccountType.Gold:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Gold));

                case AccountType.Platinum:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Platinum));

                case AccountType.Titanium:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Titanium));

                default:
                    return new Account(_accountType, _accountTypeBalanceConfig.GetValue(AccountType.Viewer));
            }
        }
    }
}
