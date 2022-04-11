using AutoMapper;
using Baking.Common.Constants;
using Banking.Application.DTO;
using Banking.Application.DTO.response;
using Banking.Application.Interfaces;
using Banking.Common.Exceptions;
using Banking.Infrastructure.Entities;
using Banking.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(
            IAccountRepository accountRepository,
            IMapper mapper
            )
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public int AddAccount(AccountServiceModel accountServiceModel)
        {
            AccountEntity entity = _mapper.Map<AccountEntity>(accountServiceModel);

            return _accountRepository.Add(entity);
        }

        public decimal GetBalanceByAccountId(int accountId)
        {
            return _accountRepository.GetBalanceByAccountId(accountId);
        }

        public void UpdateAccount(AccountServiceModel accountServiceModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateBalance(int accountId, decimal money)
        {
            var currentBalance = GetBalanceByAccountId(accountId);
            money = currentBalance - money;

            _accountRepository.UpdateBalance(accountId, money);
        }

        public bool HasAccount(int accounId)
        {
            return _accountRepository.HasAccount(accounId);
        }

        public IEnumerable<AccountServiceModel> GetAllAccountsByCustomerId(int customerId)
        {
            var entities = _accountRepository.GetAllAccountsByCustomerId(customerId);
            if (entities == null || !entities.Any())
            {
                throw new DataNotFoundException(AppErrorCodeConstants.DataNotFoundErrorCode, "Account not found");
            }

            List<AccountServiceModel> accountServiceModel = _mapper.Map<List<AccountServiceModel>>(entities).ToList();
            return accountServiceModel;
        }

        public BaseResponseModel<AccountServiceModel> GetAccountDetail(int accountId)
        {
            var entity = _accountRepository.GetAccountDetail(accountId);
            if (entity == null)
            {
                throw new DataNotFoundException(AppErrorCodeConstants.DataNotFoundErrorCode, "Account not found");
            }

            AccountServiceModel accountServiceModel = _mapper.Map<AccountServiceModel>(entity);
            return new BaseResponseModel<AccountServiceModel>(accountServiceModel, new result((int)HttpStatusCode.OK, "SUCCCESS"));
        }
    }
}
