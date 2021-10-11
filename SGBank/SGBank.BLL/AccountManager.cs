using SGBank.Models.Interfaces;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.BLL
{
    public class AccountManager
    {
        private IAccountRepository _accountRepository;
        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public AccountLookupResponse LookupAccount(string acountNumber)
        {
            AccountLookupResponse response = new AccountLookupResponse();
            response.Account = _accountRepository.LoadAccount(acountNumber);
            if(response.Account == null)
            {
                response.Success = false;
                response.Message = $"{acountNumber} is not a valid account.";
            }
            else
            {
                response.Success = true;
            }
            return response;
        }
    }
}
