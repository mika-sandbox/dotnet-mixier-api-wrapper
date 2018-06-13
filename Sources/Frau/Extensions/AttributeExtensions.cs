using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Frau.Extensions
{
    public static class AttributeExtensions
    {
        private static readonly ConcurrentDictionary<System.Enum, object> _cache = new ConcurrentDictionary<System.Enum, object>();

        public static T GetAttribute<T>(this System.Enum obj) where T : Attribute
        {
            if (_cache.ContainsKey(obj))
                return _cache[obj] as T;

            var field = obj.GetType().GetField(obj.ToString());
            var attributes = field.GetCustomAttributes(typeof(T), false).Cast<T>().ToArray();
            if (!attributes.Any())
                return null;
            var attr = attributes.First();
            return _cache.GetOrAdd(obj, attr) as T;
        }
    }
}