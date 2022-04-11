using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.request
{
    public class WithDrawRequestModel
    {
        public int customerId { get; set; }
        public int accountId { get; set; }
        public decimal money { get; set; }
    }

    public class WithDrawRequestModelValidator : AbstractValidator<WithDrawRequestModel>
    {
        public WithDrawRequestModelValidator()
        {
            RuleFor(m => m.customerId).NotEmpty();
            RuleFor(m => m.accountId).NotEmpty();
            RuleFor(m => m.money).NotEmpty();
        }
    }
}
