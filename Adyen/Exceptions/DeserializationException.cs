using System;

namespace HeadOn.Classic.Adyen.Exceptions
{
    public class DeserializationException : Exception
    {
        public DeserializationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
