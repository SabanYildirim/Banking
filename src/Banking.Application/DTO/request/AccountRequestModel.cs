using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.request
{
    public class AccountRequestModel
    {
        public int customerId { get; set; }
        public string accountName { get; set; }
        public int accountNo { get; set; }
        public decimal balance { get; set; }
        public string accountBranch { get; set; }
    }

    public class AccountRequestModelValidator : AbstractValidator<AccountRequestModel>
    {
        public AccountRequestModelValidator()
        {
            RuleFor(m => m.customerId).NotEmpty();
            RuleFor(m => m.accountNo).NotEmpty();
            RuleFor(m => m.accountBranch).NotEmpty();
            RuleFor(m => m.balance).NotEmpty();
            RuleFor(m => m.accountName).NotEmpty();
        }
    }
}
