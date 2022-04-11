using AutoMapper;
using Banking.Application.DTO;
using Banking.Application.DTO.request;
using Banking.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Banking.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CustomerController(
            ICustomerService customerService,
            IAccountService accountService,
            IMapper mapper)
        {
            _customerService = customerService;
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] CustomerRequestModel requestModel)
        {
            var validator = new CustomerRequestModelValidator();
            var result = validator.Validate(requestModel);

            if (!result.IsValid)
                throw new AccessViolationException("Violation Exception while accessing the resource.");

            CustomerServiceModel customerServiceModel = _mapper.Map<CustomerServiceModel>(requestModel);
            var customerId = _customerService.AddCustomer(customerServiceModel);

            return Created("customerId", customerId);
        }


        [HttpGet("{customerId}/accounts")]
        public IActionResult GetAllAccountsByCustomerId(int customerId)
        {
            var accounts = _accountService.GetAllAccountsByCustomerId(customerId);

            return Ok(accounts);
        }
    }
}
