import { RealVideoService } from './RealVideoService';
import { VirtualProxy } from './VirtualProxy';
import { ProtectionProxy } from './ProtectionProxy';
import { CachingProxy } from './CachingProxy';
import { LoggingProxy } from './LoggingProxy';
import { IVideoService } from './IVideoService';
import { User, SubscriptionType } from './Models';

// Proxy chain: Client -> Logging -> Caching -> Protection -> Virtual -> RealService
const realService = new RealVideoService();
const virtualProxy = new VirtualProxy(realService);
const protectionProxy = new ProtectionProxy(virtualProxy, new User('John', SubscriptionType.Free));
const cachingProxy = new CachingProxy(protectionProxy);
const loggingProxy = new LoggingProxy(cachingProxy);

const videoService: IVideoService = loggingProxy;

// SCENARIO 1: Free user watching a FREE video
console.log('SCENARIO 1: Free user watching a FREE video');
console.log('--------------------------------------------\n');
const video1 = videoService.getVideoInfo('V001');
console.log(`\nVideo: ${video1?.title}`);
console.log(`Premium: ${video1?.isPremium}\n`);
videoService.streamVideo('V001');

console.log('\n=======================================================');

// SCENARIO 2: Free user trying to watch a PREMIUM video
console.log('SCENARIO 2: Free user trying to watch PREMIUM video');
console.log('--------------------------------------------\n');
const video2 = videoService.getVideoInfo('V002');
console.log(`\nVideo: ${video2?.title}`);
console.log(`Premium: ${video2?.isPremium}\n`);
videoService.streamVideo('V002');

console.log('\n=======================================================');

// SCENARIO 3: Premium user watching PREMIUM video (new proxy chain)
console.log('SCENARIO 3: Premium user watching PREMIUM video');
console.log('--------------------------------------------\n');
const premiumProtection = new ProtectionProxy(virtualProxy, new User('Alice', SubscriptionType.Premium));
const premiumCaching = new CachingProxy(premiumProtection);
const premiumLogging = new LoggingProxy(premiumCaching);

const premiumService: IVideoService = premiumLogging;
const video3 = premiumService.getVideoInfo('V002');
console.log(`\nVideo: ${video3?.title}`);
console.log(`Premium: ${video3?.isPremium}\n`);
premiumService.streamVideo('V002');

console.log();
loggingProxy.printLogs();
(premiumLogging as LoggingProxy).printLogs();
