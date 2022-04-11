using FluentValidation;

namespace Banking.Application.DTO.request
{
    public class CustomerRequestModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }

    public class CustomerRequestModelValidator : AbstractValidator<CustomerRequestModel>
    {
        public CustomerRequestModelValidator()
        {
            RuleFor(m => m.email).NotEmpty();
            RuleFor(m => m.surname).NotEmpty();
            RuleFor(m => m.name).NotEmpty();
            RuleFor(m => m.mobile).NotEmpty();
            RuleFor(m => m.address).NotEmpty();
        }
    }
}
