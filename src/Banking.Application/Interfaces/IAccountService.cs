using Banking.Application.DTO;
using Banking.Application.DTO.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        int AddAccount(AccountServiceModel accountServiceModel);
        void UpdateAccount(AccountServiceModel accountServiceModel);
        void UpdateBalance(int accountId, decimal money);
        decimal GetBalanceByAccountId(int accountId);
        bool HasAccount(int accounId);
        IEnumerable<AccountServiceModel> GetAllAccountsByCustomerId(int customerId);
        BaseResponseModel<AccountServiceModel> GetAccountDetail(int accountId);
    }
}
