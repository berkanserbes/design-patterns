import { IVideoService } from './IVideoService';
import { Video } from './Models';

export class RealVideoService implements IVideoService {
  private readonly videoDatabase = new Map<string, Video>([
    ['V001', new Video('V001', 'Introduction to Design Patterns', false)],
    ['V002', new Video('V002', 'Advanced TypeScript Techniques', true)],
    ['V003', new Video('V003', 'SOLID Principles Explained', false)],
    ['V004', new Video('V004', 'Microservices Architecture', true)],
  ]);

  getVideoInfo(videoId: string): Video | null {
    console.log(`[RealService] Fetching video info for: ${videoId}`);
    return this.videoDatabase.get(videoId) ?? null;
  }

  streamVideo(videoId: string): void {
    console.log('[RealService] Loading video content from server...');
    const video = this.videoDatabase.get(videoId);
    if (video) {
      video.content = `[Binary video data for '${video.title}']`;
      console.log(`[RealService] Streaming: ${video.title}`);
      console.log('[RealService] Content loaded successfully');
    }
  }
}
