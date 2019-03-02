using System;
using System.Runtime.Serialization;

namespace PostMortem.Core.Exceptions
{
    [Serializable]
    public class CannotWalkHeapException : Exception
    {
        public CannotWalkHeapException()
        {
        }

        public CannotWalkHeapException(string message) : base(message)
        {
        }

        public CannotWalkHeapException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CannotWalkHeapException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
