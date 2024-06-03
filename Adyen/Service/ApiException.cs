using System;
using HeadOn.Classic.Adyen.Model;

namespace HeadOn.Classic.Adyen.Service
{
    public class ApiException:Exception
    {
        public int StatusCode { get; set; }

        public ApiError ApiError{ get; set; }

        public ApiException(int statusCode,string message)
            :base(message)
        {
            StatusCode = statusCode;
        }
    }
}
