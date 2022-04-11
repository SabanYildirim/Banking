using Banking.Application.DTO;
using Banking.Application.DTO.request;
using Banking.Application.DTO.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Interfaces
{
    public interface ITranscationService
    {
        void Addlog(TransactionLogServiceModel transcationLogServiceModel);
        BaseResponseModel<List<TransactionLogServiceModel>> GetTransactionsLogByAccountId(int accountId);
        IEnumerable<TransactionLogServiceModel> GetTransactionsLogByTimePeriod(DateTime startDate, DateTime endDate);
    }
}
