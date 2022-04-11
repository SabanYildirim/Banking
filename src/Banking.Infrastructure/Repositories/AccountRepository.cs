using Banking.Infrastructure.Context;
using Banking.Infrastructure.Entities;
using Banking.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingContext _bankingContext;

        public AccountRepository(BankingContext bankingAppContext)
        {
            _bankingContext = bankingAppContext;
        }

        public int Add(AccountEntity entity)
        {
            _bankingContext.Account.Add(entity);
            _bankingContext.SaveChanges();
            return entity.Id;
        }

        public void Delete(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public AccountEntity Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public decimal GetBalanceByAccountId(int accountId)
        {
            return _bankingContext.Account.FirstOrDefault(f => f.Id == accountId).balance;
        }

        public AccountEntity GetAccountDetail(int accountId)
        {
           return _bankingContext.Account.FirstOrDefault(f => f.Id == accountId);
        }

        public IEnumerable<AccountEntity> GetAllAccountsByCustomerId(int customerId)
        {
            return _bankingContext.Account.Where(f => f.customerId == customerId);
        }

        public bool HasAccount(int accountId)
        {
            return _bankingContext.Account.Any(f => f.Id == accountId);
        }

        public void Update(AccountEntity dbEntity, AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBalance(int accountId, decimal money)
        {
            var account = _bankingContext.Account.First(a => a.Id == accountId);
            account.balance = money;
            _bankingContext.SaveChanges();
        }
    }
}
