using Baking.Common.Constants;
using Banking.Application.Interfaces;
using Banking.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Banking.Api.Controllers
{
    [Route("api/transcation")]
    [ApiController]
    public class TranscationController : ControllerBase
    {
        private readonly ITranscationService _transcationService;

        public TranscationController(ITranscationService transcationService)
        {
            _transcationService = transcationService;
        }

        [HttpGet("{accountId}", Name = "TransactionsByAccountId")]
        public IActionResult GetTransactionsByAccountId(int accountId)
        {
            var response = _transcationService.GetTransactionsLogByAccountId(accountId);
            if (response == null)
            {
                throw new DataNotFoundException(AppErrorCodeConstants.DataNotFoundErrorCode, "Account transcation not found");
            }

            return Ok(response);
        }

        [HttpGet("{startDate}/{endDate}", Name = "TransactionsLogByTimePeriod")] //todo parametreliri düzenle
        public IActionResult GetTransactionsLogByTimePeriod(string startDate, string endDate)
        {
            var response = _transcationService.GetTransactionsLogByTimePeriod(Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
