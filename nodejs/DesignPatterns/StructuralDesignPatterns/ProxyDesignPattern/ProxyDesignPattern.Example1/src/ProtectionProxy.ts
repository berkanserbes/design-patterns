import { IVideoService } from './IVideoService';
import { Video, User, SubscriptionType } from './Models';

// PROTECTION PROXY — controls access based on subscription
export class ProtectionProxy implements IVideoService {
  constructor(
    private readonly innerService: IVideoService,
    private readonly currentUser: User,
  ) {}

  getVideoInfo(videoId: string): Video | null {
    return this.innerService.getVideoInfo(videoId);
  }

  streamVideo(videoId: string): void {
    const video = this.innerService.getVideoInfo(videoId);
    if (!video) {
      console.log(`[ProtectionProxy] Video not found: ${videoId}`);
      return;
    }
    if (video.isPremium && this.currentUser.subscription === SubscriptionType.Free) {
      console.log(`[ProtectionProxy] ACCESS DENIED: '${this.currentUser.name}' needs Premium subscription`);
      console.log(`[ProtectionProxy] Upgrade to Premium to watch: ${video.title}`);
      return;
    }
    console.log(`[ProtectionProxy] Access granted for user: ${this.currentUser.name}`);
    this.innerService.streamVideo(videoId);
  }
}
