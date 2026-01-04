// ============================================================================
// PROXY DESIGN PATTERN - Streaming Service Example
// ============================================================================
// This example demonstrates multiple proxy types working together:
//
// 1. VIRTUAL PROXY    - Lazy loads video content (loads only when needed)
// 2. PROTECTION PROXY - Controls access based on subscription (Free/Premium)
// 3. CACHING PROXY    - Caches video metadata to reduce server calls
// 4. LOGGING PROXY    - Logs all operations for analytics
//
// Proxy Chain: Client -> Logging -> Caching -> Protection -> Virtual -> RealService
// ============================================================================

using ProxyDesignPattern.Example1;

// Create the real service
var realService = new RealVideoService();

// Build the proxy chain (order matters!)
// Each proxy wraps the previous one
var virtualProxy = new VirtualProxy(realService);
var protectionProxy = new ProtectionProxy(virtualProxy, new User("John", SubscriptionType.Free));
var cachingProxy = new CachingProxy(protectionProxy);
var loggingProxy = new LoggingProxy(cachingProxy);

// Client uses the outermost proxy
IVideoService videoService = loggingProxy;

// ============================================================================
// SCENARIO 1: Free user tries to watch a FREE video
// ============================================================================
Console.WriteLine("SCENARIO 1: Free user watching a FREE video");
Console.WriteLine("--------------------------------------------\n");

var video = videoService.GetVideoInfo("V001");
Console.WriteLine($"\nVideo: {video?.Title}");
Console.WriteLine($"Premium: {video?.IsPremium}\n");

videoService.StreamVideo("V001");

Console.WriteLine("\n");

// ============================================================================
// SCENARIO 2: Free user tries to watch a PREMIUM video
// ============================================================================
Console.WriteLine("=======================================================");
Console.WriteLine("SCENARIO 2: Free user trying to watch PREMIUM video");
Console.WriteLine("--------------------------------------------\n");

video = videoService.GetVideoInfo("V002");
Console.WriteLine($"\nVideo: {video?.Title}");
Console.WriteLine($"Premium: {video?.IsPremium}\n");

videoService.StreamVideo("V002");

Console.WriteLine("\n");

// ============================================================================
// SCENARIO 3: Premium user watches a PREMIUM video
// ============================================================================
Console.WriteLine("=======================================================");
Console.WriteLine("SCENARIO 3: Premium user watching PREMIUM video");
Console.WriteLine("--------------------------------------------\n");

// Create new proxy chain with Premium user
var premiumProtection = new ProtectionProxy(virtualProxy, new User("Alice", SubscriptionType.Premium));
var premiumCaching = new CachingProxy(premiumProtection);
var premiumLogging = new LoggingProxy(premiumCaching);

IVideoService premiumService = premiumLogging;

video = premiumService.GetVideoInfo("V002");
Console.WriteLine($"\nVideo: {video?.Title}");
Console.WriteLine($"Premium: {video?.IsPremium}\n");

premiumService.StreamVideo("V002");

Console.WriteLine("\n");

// ============================================================================
// SCENARIO 4: Caching in action (request same video again)
// ============================================================================
Console.WriteLine("=======================================================");
Console.WriteLine("SCENARIO 4: Caching in action");
Console.WriteLine("--------------------------------------------\n");

Console.WriteLine("Requesting same video info again...\n");
video = premiumService.GetVideoInfo("V002");
Console.WriteLine($"\nVideo: {video?.Title} (served from cache!)\n");

// ============================================================================
// SUMMARY
// ============================================================================
Console.WriteLine("=======================================================");
Console.WriteLine("SUMMARY\n");
Console.WriteLine("This example demonstrated 4 proxy types:\n");
Console.WriteLine("1. VIRTUAL PROXY    - Delayed video content loading");
Console.WriteLine("2. PROTECTION PROXY - Blocked free user from premium content");
Console.WriteLine("3. CACHING PROXY    - Cached video info on second request");
Console.WriteLine("4. LOGGING PROXY    - Logged all service calls");
Console.WriteLine("\nProxies can be chained to add multiple behaviors!");
Console.WriteLine("=======================================================");
