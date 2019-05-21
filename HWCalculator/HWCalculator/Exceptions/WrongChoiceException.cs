using System;
using System.Runtime.Serialization;

namespace HWCalculator
{
    [Serializable]
    internal class WrongChoiceException : Exception
    {
        public WrongChoiceException()
        {
        }

        public WrongChoiceException(string message) : base(message)
        {
        }

        public WrongChoiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongChoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}