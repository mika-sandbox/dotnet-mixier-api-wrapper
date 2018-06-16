using System.Collections.Generic;

using Frau.Models.Bucket;

namespace Frau.Extensions
{
    internal static class SearchParameterExtensions
    {
        public static void AddTo(this SearchParameter obj, List<KeyValuePair<string, string>> parameters)
        {
            if (!string.IsNullOrWhiteSpace(obj.Order))
                parameters.Add(new KeyValuePair<string, string>("order", obj.Order));
            if (obj.Page.HasValue)
                parameters.Add(new KeyValuePair<string, string>("page", obj.Page.Value.ToString()));
            if (obj.Limit.HasValue)
                parameters.Add(new KeyValuePair<string, string>("limit", obj.Limit.Value.ToString()));
            if (!string.IsNullOrWhiteSpace(obj.Where))
                parameters.Add(new KeyValuePair<string, string>("where", obj.Where));
            if (!string.IsNullOrWhiteSpace(obj.Fields))
                parameters.Add(new KeyValuePair<string, string>("fields", obj.Fields));
            if (obj.NoCount.HasValue)
                parameters.Add(new KeyValuePair<string, string>("noCount", obj.NoCount.Value.ToString().ToLower()));
        }
    }
}