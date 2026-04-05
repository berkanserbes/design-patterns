import { FileUploadRequest } from "../FileUploadRequest";
import { BaseFileHandler } from "../BaseFileHandler";

const VIRUS_SIGNATURES = ["MALWARE", "VIRUS", "TROJAN"];

export class VirusScannerHandler extends BaseFileHandler {
  handle(request: FileUploadRequest): void {
    const content = request.fileContent.toString("utf8");
    const virusDetected = VIRUS_SIGNATURES.some((sig) =>
      content.toUpperCase().includes(sig)
    );
    if (virusDetected) {
      request.isValid = false;
      request.validationMessages.push("Virus detected! File rejected.");
      return;
    }
    super.handle(request);
  }
}
