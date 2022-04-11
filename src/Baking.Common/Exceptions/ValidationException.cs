using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Common.Exceptions
{
    public class ValidationException : BankingBaseException
    {
        public ValidationException(int errorCode, string message) : base(errorCode, message)
        {
        }
    }
}
