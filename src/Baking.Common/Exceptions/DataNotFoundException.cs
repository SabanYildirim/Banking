namespace Banking.Common.Exceptions
{
    public class DataNotFoundException : BankingBaseException
    {
        public DataNotFoundException(int errorCode, string message) : base(errorCode, message)
        {
        }
    }
}
