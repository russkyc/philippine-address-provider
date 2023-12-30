using System;
using System.Globalization;

namespace Russkyc.Addressess.Philippines.Utils
{
    public static class StringComparator
    {
        public static bool ContainsIgnoreCase(this string source, string target)
        {
            return CultureInfo.InvariantCulture.CompareInfo.IndexOf(source, target, CompareOptions.IgnoreCase) >= 0;
        }

        public static bool EqualsIgnoreCase(this string source, string target)
        {
            return string.Equals(source, target, StringComparison.OrdinalIgnoreCase);
        }
    }
}