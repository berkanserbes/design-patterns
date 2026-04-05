import { IImage } from "./IImage";

const sleep = (ms: number) => new Promise((resolve) => setTimeout(resolve, ms));

/**
 * RealSubject - The actual high-resolution image.
 * Creating this object is expensive (simulated with delay).
 */
export class HighResolutionImage implements IImage {
  constructor(private readonly _fileName: string) {}

  static async create(fileName: string): Promise<HighResolutionImage> {
    const img = new HighResolutionImage(fileName);
    await img._loadImageFromDisk();
    return img;
  }

  private async _loadImageFromDisk(): Promise<void> {
    console.log(`[RealImage] Loading image: ${this._fileName}`);
    console.log("[RealImage] Connecting to storage...");
    await sleep(1000);

    console.log("[RealImage] Downloading image data...");
    await sleep(1500);

    console.log(`[RealImage] Image '${this._fileName}' loaded successfully!`);
  }

  async display(): Promise<void> {
    console.log(`[RealImage] Displaying: ${this._fileName}`);
  }
}
