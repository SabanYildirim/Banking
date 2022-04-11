﻿using Banking.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Interfaces
{
    public interface ICustormerRepository : IDataRepository<CustomerEntity>
    {
    }
}
