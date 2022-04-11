using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Banking.Application.DTO.request;
using Banking.Infrastructure.Entities;

namespace Banking.Application.DTO.MapperProfile
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountRequestModel, AccountServiceModel>();
            CreateMap<AccountServiceModel, AccountEntity>();
            CreateMap<AccountEntity, AccountServiceModel>();
        }
    }
}
