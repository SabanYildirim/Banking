using AutoMapper;
using Banking.Application.DTO.request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.MapperProfile
{
    public class WithdrawProfile : Profile
    {
        public WithdrawProfile()
        {
            CreateMap<WithDrawRequestModel, WithDrawServiceModel>();
        }
    }
}
