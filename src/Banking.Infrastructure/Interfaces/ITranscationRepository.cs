using Banking.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Banking.Infrastructure.Interfaces
{
    public interface ITranscationRepository
    {
        void AddLog(TransactionLogEntity transactionLogEntity);
        IEnumerable<TransactionLogEntity> GetTransactionsLogByAccountId(int accountId);
        IEnumerable<TransactionLogEntity> GetTransactionsLogByTimePeriod(DateTime startDate, DateTime endDate);
    }
}
