using System;
using System.Runtime.Serialization;

namespace Demo.Application.Common.Exception
{
    [Serializable]
    public class BadRequestException : System.Exception
    {
        public BadRequestException(string message)
            : base(message)
        {
        }

        protected BadRequestException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
        }

    }
}
