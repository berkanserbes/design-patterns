import { HighResolutionImage } from "./HighResolutionImage";
import { IImage } from "./IImage";

/**
 * Virtual Proxy - Controls access to the real image.
 * Creates the real image only when display() is called (lazy loading).
 */
export class ImageProxy implements IImage {
  private _realImage: HighResolutionImage | null = null;
  private _loading = false;

  constructor(private readonly _fileName: string) {
    console.log(`[Proxy] Proxy created for: ${_fileName}`);
  }

  async display(): Promise<void> {
    if (this._realImage === null && !this._loading) {
      this._loading = true;
      console.log(`[Proxy] First access - loading real image...`);
      this._realImage = await HighResolutionImage.create(this._fileName);
      this._loading = false;
    }

    await this._realImage!.display();
  }

  get isLoaded(): boolean {
    return this._realImage !== null;
  }
}
