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
    public class TranscationRepository : ITranscationRepository
    {
        private readonly BankingContext _bankingContext;

        public TranscationRepository(BankingContext bankingAppContext)
        {
            _bankingContext = bankingAppContext;
        }

        public void AddLog(TransactionLogEntity transactionLogEntity)
        {
            _bankingContext.TransactionLog.Add(transactionLogEntity);
            _bankingContext.SaveChanges();
        }

        public IEnumerable<TransactionLogEntity> GetTransactionsLogByAccountId(int accountId)
        {
            return _bankingContext.TransactionLog.Where(x => x.AccountId == accountId);
        }

        public IEnumerable<TransactionLogEntity> GetTransactionsLogByTimePeriod(DateTime startDate, DateTime endDate)
        {
            return _bankingContext.TransactionLog.Where(x => x.CreatedDate >= startDate && x.CreatedDate <= endDate);
        }
    }
}
