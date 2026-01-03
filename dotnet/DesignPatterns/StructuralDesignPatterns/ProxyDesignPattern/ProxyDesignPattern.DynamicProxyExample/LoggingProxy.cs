using System.Diagnostics;
using System.Reflection;

namespace ProxyDesignPattern.DynamicProxyExample;

/// <summary>
/// Dynamic Proxy using DispatchProxy (built-in .NET).
/// Automatically logs all method calls on any interface at runtime.
/// No need to create a separate proxy class for each interface!
/// </summary>
public class LoggingProxy<T> : DispatchProxy where T : class
{
    private T? _target;

    /// <summary>
    /// Creates a dynamic proxy that wraps the target object.
    /// </summary>
    public static T Create(T target)
    {
        // Create proxy instance
        var proxy = Create<T, LoggingProxy<T>>();
        
        // Set the target
        ((LoggingProxy<T>)(object)proxy)._target = target;
        
        return proxy;
    }

    /// <summary>
    /// Intercepts all method calls on the proxy.
    /// </summary>
    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
        if (targetMethod == null || _target == null)
            return null;

        var methodName = targetMethod.Name;
        var argsString = args != null ? string.Join(", ", args) : "";

        // Before method execution
        Console.WriteLine($"[Proxy] Calling: {typeof(T).Name}.{methodName}({argsString})");
        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Invoke the actual method
            var result = targetMethod.Invoke(_target, args);

            stopwatch.Stop();

            // After method execution
            Console.WriteLine($"[Proxy] Returned: {result} (took {stopwatch.ElapsedMilliseconds}ms)");

            return result;
        }
        catch (TargetInvocationException ex)
        {
            stopwatch.Stop();
            Console.WriteLine($"[Proxy] Exception: {ex.InnerException?.Message} (took {stopwatch.ElapsedMilliseconds}ms)");
            throw ex.InnerException ?? ex;
        }
    }
}
