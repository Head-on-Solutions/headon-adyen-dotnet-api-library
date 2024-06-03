using System;

namespace HeadOn.Classic.Adyen.Security.Exceptions
{
    public class NexoCryptoException : Exception
    {
        public NexoCryptoException(string message) : base(message)
        {
        }
    }
}
