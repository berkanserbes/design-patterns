import { FileUploadRequest } from "../FileUploadRequest";
import { BaseFileHandler } from "../BaseFileHandler";

const FORBIDDEN_WORDS = ["CONFIDENTIAL_LEAK", "SECRET_DATA", "BANNED_CONTENT"];

export class ContentValidatorHandler extends BaseFileHandler {
  handle(request: FileUploadRequest): void {
    const content = request.fileContent.toString("utf8");
    const found = FORBIDDEN_WORDS.filter((w) => content.toUpperCase().includes(w));
    if (found.length > 0) {
      request.isValid = false;
      request.validationMessages.push(
        `Forbidden content detected: ${found.join(", ")}`
      );
      return;
    }
    super.handle(request);
  }
}
