﻿using System.Runtime.Serialization;

namespace BankOfSuccess.BuisnessLogicLayer
{
    [Serializable]
    internal class DebitCardExpiredException : Exception
    {
        public DebitCardExpiredException()
        {
        }

        public DebitCardExpiredException(string? message) : base(message)
        {
        }

        public DebitCardExpiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DebitCardExpiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}