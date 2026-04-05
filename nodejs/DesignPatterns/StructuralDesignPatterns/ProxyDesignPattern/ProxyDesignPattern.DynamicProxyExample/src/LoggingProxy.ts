// ============================================================================
// DYNAMIC PROXY USING JAVASCRIPT'S NATIVE Proxy OBJECT
// ============================================================================
// JavaScript's built-in Proxy is the direct equivalent of .NET's DispatchProxy.
// It intercepts all property accesses and method calls at runtime.
//
// Benefits:
//   - No need to create a separate proxy class for each interface
//   - One createLoggingProxy<T> works for ANY object
//   - Add cross-cutting concerns (logging, timing, etc.) dynamically
// ============================================================================

/**
 * Creates a dynamic logging proxy that wraps any object.
 * Intercepts all method calls, logs arguments and return values, and measures timing.
 *
 * Uses JavaScript's native Proxy object — the equivalent of .NET's DispatchProxy.
 */
export function createLoggingProxy<T extends object>(target: T, interfaceName: string): T {
  return new Proxy(target, {
    get(obj: T, prop: string | symbol) {
      const value = (obj as Record<string | symbol, unknown>)[prop];

      // Only intercept function calls
      if (typeof value !== "function") {
        return value;
      }

      return function (...args: unknown[]) {
        const methodName = String(prop);
        const argsString = args.join(", ");

        // Before method execution
        console.log(`[Proxy] Calling: ${interfaceName}.${methodName}(${argsString})`);
        const start = Date.now();

        try {
          // Invoke the actual method
          const result = (value as (...a: unknown[]) => unknown).apply(obj, args);

          const elapsed = Date.now() - start;
          console.log(`[Proxy] Returned: ${result} (took ${elapsed}ms)`);

          return result;
        } catch (err: unknown) {
          const elapsed = Date.now() - start;
          const message = err instanceof Error ? err.message : String(err);
          console.log(`[Proxy] Exception: ${message} (took ${elapsed}ms)`);
          throw err;
        }
      };
    },
  });
}
