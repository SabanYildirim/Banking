using Banking.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Context
{
    public class BankingContext : DbContext
    {
        public BankingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<CustomerEntity> Custormer { get; set; }
        public DbSet<AccountEntity> Account { get; set; }
        public DbSet<TransactionLogEntity> TransactionLog { get; set; }
    }
}
