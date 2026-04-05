import { Video } from './Models';

export interface IVideoService {
  getVideoInfo(videoId: string): Video | null;
  streamVideo(videoId: string): void;
}
