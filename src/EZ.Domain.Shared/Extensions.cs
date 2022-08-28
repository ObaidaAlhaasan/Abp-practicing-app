using System;
using System.Linq;
using JetBrains.Annotations;

namespace EZ;

public static class Extensions
{
    public static bool IsNotNull(this object value)
    {
        return value != null;
    }

    public static bool IsNull(this object value)
    {
        return value == null;
    }
    
    
    public static bool IsNotNullOrWhiteSpace(this string value)
    {
        return string.IsNullOrWhiteSpace(value) == false;
    }
    
    public static bool ContainsIgnoreCase([CanBeNull] this string value, [CanBeNull] string search)
    {
        return value?.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;        
    }
}