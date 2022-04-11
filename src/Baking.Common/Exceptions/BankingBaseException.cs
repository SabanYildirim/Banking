using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Common.Exceptions
{
    public class BankingBaseException : Exception
    {
        public int ErrorCode { get; private set; }
        public BankingBaseException(int errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }
    }
}
