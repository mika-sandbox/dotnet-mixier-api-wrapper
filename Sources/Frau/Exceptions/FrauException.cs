using System;

using Frau.Models.Flow;

using Newtonsoft.Json;

namespace Frau.Exceptions
{
    public class FrauException : Exception
    {
        public ErrorResponse Error { get; }
        public string RawError { get; }

        public FrauException(string error, string message, Exception e) : base(message, e)
        {
            Error = JsonConvert.DeserializeObject<ErrorResponse>(error);
            RawError = error;
        }
    }
}