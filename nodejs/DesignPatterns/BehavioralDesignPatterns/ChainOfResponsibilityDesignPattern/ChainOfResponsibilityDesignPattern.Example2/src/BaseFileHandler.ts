import { FileUploadRequest, IFileHandler } from "./FileUploadRequest";

export abstract class BaseFileHandler implements IFileHandler {
  private _nextHandler: IFileHandler | null = null;

  setNext(handler: IFileHandler): IFileHandler {
    this._nextHandler = handler;
    return handler;
  }

  handle(request: FileUploadRequest): void {
    if (this._nextHandler) {
      this._nextHandler.handle(request);
    }
  }
}
