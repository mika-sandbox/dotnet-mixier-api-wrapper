using System;

namespace Frau.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ScopeAttribute : Attribute
    {
        public string Str { get; }

        public ScopeAttribute(string str)
        {
            Str = str;
        }
    }
}