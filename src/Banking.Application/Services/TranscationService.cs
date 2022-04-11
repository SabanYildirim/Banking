using AutoMapper;
using Banking.Application.DTO;
using Banking.Application.DTO.response;
using Banking.Application.Interfaces;
using Banking.Infrastructure.Entities;
using Banking.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Services
{
    public class TranscationService : ITranscationService
    {
        private readonly ITranscationRepository _transcationRepository;
        private readonly IMapper _mapper;

        public TranscationService(ITranscationRepository transcationRepository, IMapper mapper)
        {
            _transcationRepository = transcationRepository;
            _mapper = mapper;
        }

        public void Addlog(TransactionLogServiceModel transcationLogServiceModel)
        {
            TransactionLogEntity entity = _mapper.Map<TransactionLogEntity>(transcationLogServiceModel);

            _transcationRepository.AddLog(entity);
        }

        public BaseResponseModel<List<TransactionLogServiceModel>> GetTransactionsLogByAccountId(int accountId)
        {
            var logs = _transcationRepository.GetTransactionsLogByAccountId(accountId).ToList();

            List<TransactionLogServiceModel> transactionLogServiceModel = _mapper.Map<List<TransactionLogServiceModel>>(logs).ToList();

            if(!transactionLogServiceModel.Any())
            {
                return null;
            }

            return new BaseResponseModel<List<TransactionLogServiceModel>>(transactionLogServiceModel, new result(200, "SUCCCESS"));
        }

        public IEnumerable<TransactionLogServiceModel> GetTransactionsLogByTimePeriod(DateTime startDate, DateTime endDate)
        {
            var logs = _transcationRepository.GetTransactionsLogByTimePeriod(startDate, endDate).ToList();

            List<TransactionLogServiceModel> transactionLogServiceModel = _mapper.Map<List<TransactionLogServiceModel>>(logs).ToList();
            return transactionLogServiceModel;
        }
    }
}
