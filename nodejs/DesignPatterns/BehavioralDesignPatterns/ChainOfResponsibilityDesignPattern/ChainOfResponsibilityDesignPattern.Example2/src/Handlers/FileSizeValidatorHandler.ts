import { FileUploadRequest } from "../FileUploadRequest";
import { BaseFileHandler } from "../BaseFileHandler";

const MAX_FILE_SIZE_BYTES = 10 * 1024 * 1024; // 10 MB

export class FileSizeValidatorHandler extends BaseFileHandler {
  handle(request: FileUploadRequest): void {
    if (request.fileSizeInBytes > MAX_FILE_SIZE_BYTES) {
      request.isValid = false;
      request.validationMessages.push(
        `File size exceeds maximum allowed size of ${MAX_FILE_SIZE_BYTES / (1024 * 1024)} MB.`
      );
      return;
    }
    super.handle(request);
  }
}
