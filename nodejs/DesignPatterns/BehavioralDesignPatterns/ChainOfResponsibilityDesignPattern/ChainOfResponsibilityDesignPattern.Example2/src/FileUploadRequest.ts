export interface IFileHandler {
  setNext(handler: IFileHandler): IFileHandler;
  handle(request: FileUploadRequest): void;
}

export class FileUploadRequest {
  isValid = true;
  readonly validationMessages: string[] = [];

  constructor(
    public readonly fileName: string,
    public readonly fileExtension: string,
    public readonly fileSizeInBytes: number,
    public readonly fileContent: Buffer
  ) {}

  getFileSizeInMB(): number {
    return this.fileSizeInBytes / (1024 * 1024);
  }
}
