using System;
using System.Runtime.Serialization;

namespace PostMortem.Core.Exceptions
{
    [Serializable]
    public class LoadDumpException : Exception
    {
        public LoadDumpException()
        {
        }

        public LoadDumpException(string message) : base(message)
        {
        }

        public LoadDumpException(string message, Exception inner) : base(message, inner)
        {
        }

        protected LoadDumpException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
