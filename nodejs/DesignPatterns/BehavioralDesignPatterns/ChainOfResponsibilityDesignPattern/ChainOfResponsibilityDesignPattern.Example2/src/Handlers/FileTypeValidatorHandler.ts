import { FileUploadRequest } from "../FileUploadRequest";
import { BaseFileHandler } from "../BaseFileHandler";

const ALLOWED_EXTENSIONS = [".pdf", ".doc", ".docx", ".txt", ".jpg", ".jpeg", ".png", ".gif"];

export class FileTypeValidatorHandler extends BaseFileHandler {
  handle(request: FileUploadRequest): void {
    if (!ALLOWED_EXTENSIONS.includes(request.fileExtension.toLowerCase())) {
      request.isValid = false;
      request.validationMessages.push(
        `File type '${request.fileExtension}' is not allowed. Allowed: ${ALLOWED_EXTENSIONS.join(", ")}`
      );
      return;
    }
    super.handle(request);
  }
}
