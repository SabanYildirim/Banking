using AutoMapper;
using Banking.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.MapperProfile
{
    public class TranscationProfile : Profile
    {
        public TranscationProfile()
        {
            CreateMap<TransactionLogEntity, TransactionLogServiceModel>();
            CreateMap<TransactionLogServiceModel, TransactionLogEntity>();

        }
    }
}
