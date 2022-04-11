﻿using Banking.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Interfaces
{
    public interface IWithDrawService
    {
        public bool WithDraw(WithDrawServiceModel withDrawServiceModel);
    }
}
