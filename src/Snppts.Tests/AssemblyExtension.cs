using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Snppts.Tests;

/// Extension class based in this solution https://stackoverflow.com/questions/11915389/assembly-gettypes-throwing-an-exception
public static class AssemblyExtension
{
    public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
    {
        if (assembly == null) throw new ArgumentNullException(nameof(assembly));

        try
        {
            return assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException e)
        {
            return e.Types.Where(t => t != null);
        }
    }
}
