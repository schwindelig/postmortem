using System;
using System.Runtime.Serialization;

namespace PostMortem.Core.Exceptions
{
    [Serializable]
    public class HeapCorruptedException : Exception
    {
        public HeapCorruptedException()
        {
        }

        public HeapCorruptedException(string message) : base(message)
        {
        }

        public HeapCorruptedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected HeapCorruptedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
