using Banking.Infrastructure.Context;
using Banking.Infrastructure.Entities;
using Banking.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace Banking.Infrastructure.Repositories
{
    public class CustormerRepository : ICustormerRepository
    {
        private readonly BankingContext _bankingContext;
        public CustormerRepository(BankingContext bankingContext)
        {
            _bankingContext = bankingContext;
        }

        public int Add(CustomerEntity entity)
        {
            _bankingContext.Custormer.Add(entity);
            _bankingContext.SaveChanges();
            return entity.Id;
        }

        public void Delete(CustomerEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public CustomerEntity Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CustomerEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(CustomerEntity dbEntity, CustomerEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}