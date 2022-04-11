using AutoMapper;
using Banking.Application.DTO.request;
using Banking.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.MapperProfile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerRequestModel, CustomerServiceModel>().ReverseMap();
            CreateMap<CustomerServiceModel, CustomerEntity>();
            CreateMap<CustomerEntity, CustomerServiceModel>();

        }
    }
}
