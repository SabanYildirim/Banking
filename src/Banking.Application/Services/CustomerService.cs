using AutoMapper;
using Banking.Application.DTO;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustormerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustormerRepository custormerRepository, IMapper mapper)
        {
            _customerRepository = custormerRepository;
            _mapper = mapper;
        }

        public int AddCustomer(CustomerServiceModel customerServiceModel)
        {
            CustomerEntity entity = _mapper.Map<CustomerEntity>(customerServiceModel);

            return _customerRepository.Add(entity);
        }
    }
}
