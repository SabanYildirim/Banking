using AutoMapper;
using Banking.Application.DTO;
using Banking.Application.DTO.request;
using Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Banking.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(
            IAccountService accountService,
            IMapper mapper
            )
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var account = _accountService.GetAccountDetail(id);

            return Ok(account);
        }

        [HttpPost]
        public IActionResult Add([FromBody] AccountRequestModel accountRequestModel)
        {
            var validator = new AccountRequestModelValidator();
            var result = validator.Validate(accountRequestModel);

            if (!result.IsValid)
                throw new AccessViolationException("Violation Exception while accessing the resource.");

            AccountServiceModel accountServiceModel = _mapper.Map<AccountServiceModel>(accountRequestModel);

            int accountId = _accountService.AddAccount(accountServiceModel);

            return Created("account/accountId", accountId);
        }
    }
}
