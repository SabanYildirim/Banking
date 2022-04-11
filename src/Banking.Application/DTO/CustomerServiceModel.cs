using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO
{
    public class CustomerServiceModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
