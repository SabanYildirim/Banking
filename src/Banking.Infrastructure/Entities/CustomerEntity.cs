using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Entities
{
    [Table("Customers")]
    public class CustomerEntity : BaseEntity
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
