import { IVideoService } from './IVideoService';
import { Video } from './Models';

// LOGGING PROXY — logs all operations
export class LoggingProxy implements IVideoService {
  private readonly logs: string[] = [];

  constructor(private readonly innerService: IVideoService) {}

  getVideoInfo(videoId: string): Video | null {
    const ts = new Date().toLocaleTimeString();
    this.logs.push(`[${ts}] GetVideoInfo called for: ${videoId}`);
    console.log(`[LoggingProxy] Logging: getVideoInfo(${videoId})`);
    return this.innerService.getVideoInfo(videoId);
  }

  streamVideo(videoId: string): void {
    const ts = new Date().toLocaleTimeString();
    this.logs.push(`[${ts}] StreamVideo called for: ${videoId}`);
    console.log(`[LoggingProxy] Logging: streamVideo(${videoId})`);
    this.innerService.streamVideo(videoId);
  }

  printLogs(): void {
    console.log('\n--- Activity Logs ---');
    for (const log of this.logs) console.log(log);
    console.log('---------------------');
  }
}
