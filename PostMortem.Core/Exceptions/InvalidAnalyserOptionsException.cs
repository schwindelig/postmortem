using System;
using System.Runtime.Serialization;

namespace PostMortem.Core.Exceptions
{
    [Serializable]
    public class InvalidOptionsException : Exception
    {
        public InvalidOptionsException()
        {
        }

        public InvalidOptionsException(string message) : base(message)
        {
        }

        public InvalidOptionsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidOptionsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
