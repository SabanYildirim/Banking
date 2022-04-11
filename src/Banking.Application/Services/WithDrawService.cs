using Baking.Common.Constants;
using Banking.Application.DTO;
using Banking.Application.Interfaces;
using Banking.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Banking.Application.Services
{
    public class WithDrawService : IWithDrawService
    {
        private readonly IAccountService _accountService;
        private readonly ITranscationService _transcationService;
        public WithDrawService(IAccountService accountService, ITranscationService transcationService)
        {
            _accountService = accountService;
            _transcationService = transcationService;
        }
        
        public bool WithDraw(WithDrawServiceModel withDrawServiceModel)
        {
            if(!_accountService.HasAccount(withDrawServiceModel.accountId))
            {
                throw new DataNotFoundException(AppErrorCodeConstants.DataNotFoundErrorCode, "Account not found");
            };

            using (TransactionScope scope = new TransactionScope())
            {
                _accountService.UpdateBalance(withDrawServiceModel.accountId, withDrawServiceModel.money);

                TransactionLogServiceModel transactionLogServiceModel = new TransactionLogServiceModel();

                transactionLogServiceModel.accountId = withDrawServiceModel.accountId;
                transactionLogServiceModel.customerId = withDrawServiceModel.customerId;
                transactionLogServiceModel.balance = withDrawServiceModel.money;

                _transcationService.Addlog(transactionLogServiceModel);

                scope.Complete();
            }

            return true;
        }
    }
}
