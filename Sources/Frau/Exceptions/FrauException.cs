using System;

using Frau.Models.Flow;

namespace Frau.Exceptions
{
    public class FrauException : Exception
    {
        public ErrorResponse Error { get; }

        public FrauException(ErrorResponse error, string message, Exception e) : base(message, e)
        {
            Error = error;
        }
    }
}