import { IVideoService } from './IVideoService';
import { Video } from './Models';

// VIRTUAL PROXY — lazy loads video content
export class VirtualProxy implements IVideoService {
  private readonly loadedVideos = new Map<string, Video>();

  constructor(private readonly realService: IVideoService) {}

  getVideoInfo(videoId: string): Video | null {
    return this.realService.getVideoInfo(videoId);
  }

  streamVideo(videoId: string): void {
    if (this.loadedVideos.has(videoId)) {
      console.log('[VirtualProxy] Video already loaded, reusing content');
      return;
    }
    console.log('[VirtualProxy] First time access - loading video content lazily');
    this.realService.streamVideo(videoId);
    const video = this.realService.getVideoInfo(videoId);
    if (video) this.loadedVideos.set(videoId, video);
  }
}
