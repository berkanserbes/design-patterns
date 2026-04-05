import { IVideoService } from './IVideoService';
import { Video } from './Models';

// CACHING PROXY — caches video metadata
export class CachingProxy implements IVideoService {
  private readonly cache = new Map<string, Video>();

  constructor(private readonly innerService: IVideoService) {}

  getVideoInfo(videoId: string): Video | null {
    if (this.cache.has(videoId)) {
      console.log(`[CachingProxy] Cache HIT for video: ${videoId}`);
      return this.cache.get(videoId)!;
    }
    console.log(`[CachingProxy] Cache MISS for video: ${videoId}`);
    const video = this.innerService.getVideoInfo(videoId);
    if (video) {
      this.cache.set(videoId, video);
      console.log(`[CachingProxy] Video info cached: ${videoId}`);
    }
    return video;
  }

  streamVideo(videoId: string): void {
    this.innerService.streamVideo(videoId);
  }
}
