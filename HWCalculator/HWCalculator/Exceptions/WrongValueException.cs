using System;
using System.Runtime.Serialization;

namespace HWCalculator
{
    [Serializable]
    internal class WrongValueException : Exception
    {
        public WrongValueException()
        {
        }

        public WrongValueException(string message) : base(message)
        {
        }

        public WrongValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}