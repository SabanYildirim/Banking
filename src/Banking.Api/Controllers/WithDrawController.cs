using AutoMapper;
using Baking.Common.Constants;
using Banking.Application.DTO;
using Banking.Application.DTO.request;
using Banking.Application.DTO.response;
using Banking.Application.Interfaces;
using Banking.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Banking.Api.Controllers
{
    [Route("api/withdraw")]
    [ApiController]
    public class WithDrawController : ControllerBase
    {
        private readonly IWithDrawService _withdrawService;
        private readonly IMapper _mapper;

        public WithDrawController(IWithDrawService withdrawService, IMapper mapper)
        {
            _withdrawService = withdrawService;
            _mapper = mapper;
        }

        [HttpPut]
        public IActionResult withdraw([FromBody] WithDrawRequestModel withDrawRequestModel)
        {
            var validator = new WithDrawRequestModelValidator();
            var result = validator.Validate(withDrawRequestModel);

            if (!result.IsValid)
                throw new ValidationException(AppErrorCodeConstants.ValidationErrorCode,"Validation Exception");

            WithDrawServiceModel withDrawServiceModel = _mapper.Map<WithDrawServiceModel>(withDrawRequestModel);

            _withdrawService.WithDraw(withDrawServiceModel);
            
            return Ok(new SuccessReponseModel { Success = true });
        }
    }
}
