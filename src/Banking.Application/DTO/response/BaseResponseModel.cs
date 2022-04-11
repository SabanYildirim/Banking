using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO.response
{
    public class BaseResponseModel<T> where T : new()
    {
        public T data { get; private set; }
        public result result { get; private set; }

        public BaseResponseModel(T data, result result)
        {
            this.data = data;
            this.result = result;
        }
    }

    public class result
    {
        public string message { get; private set; }
        public int code { get; private set; }

        public result(int code, string message)
        {
            this.code = code;
            this.message=message;
        }
    }
}
