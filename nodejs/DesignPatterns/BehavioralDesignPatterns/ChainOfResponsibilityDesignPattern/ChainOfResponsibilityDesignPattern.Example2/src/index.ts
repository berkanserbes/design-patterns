// ============================================================================
// CHAIN OF RESPONSIBILITY - Example 2: File Upload Processing Pipeline
// ============================================================================
// Chain: VirusScanner → FileSizeValidator → FileTypeValidator → ContentValidator
// Each handler validates one concern and either passes or rejects the file.

import { ContentValidatorHandler } from "./Handlers/ContentValidatorHandler";
import { FileSizeValidatorHandler } from "./Handlers/FileSizeValidatorHandler";
import { FileTypeValidatorHandler } from "./Handlers/FileTypeValidatorHandler";
import { VirusScannerHandler } from "./Handlers/VirusScannerHandler";
import { FileUploadRequest } from "./FileUploadRequest";

function printResult(request: FileUploadRequest): void {
  console.log(`File: ${request.fileName} (${request.getFileSizeInMB().toFixed(2)} MB)`);
  if (request.isValid) {
    console.log("Status: APPROVED - File validated successfully!\n");
  } else {
    console.log("Status: REJECTED");
    console.log("Reasons:");
    for (const msg of request.validationMessages) {
      console.log(`  • ${msg}`);
    }
    console.log();
  }
}

// Build the chain
const virusScanner      = new VirusScannerHandler();
const fileSizeValidator = new FileSizeValidatorHandler();
const fileTypeValidator = new FileTypeValidatorHandler();
const contentValidator  = new ContentValidatorHandler();

virusScanner
  .setNext(fileSizeValidator)
  .setNext(fileTypeValidator)
  .setNext(contentValidator);

const scenarios: FileUploadRequest[] = [
  new FileUploadRequest(
    "document.pdf", ".pdf", 2 * 1024 * 1024,
    Buffer.from("This is a valid PDF document content.")
  ),
  new FileUploadRequest(
    "infected.doc", ".doc", 1 * 1024 * 1024,
    Buffer.from("This file contains a VIRUS signature.")
  ),
  new FileUploadRequest(
    "large_video.mp4", ".mp4", 15 * 1024 * 1024,
    Buffer.from("Large video content...")
  ),
  new FileUploadRequest(
    "script.exe", ".exe", 500 * 1024,
    Buffer.from("Executable content...")
  ),
  new FileUploadRequest(
    "report.txt", ".txt", 100 * 1024,
    Buffer.from("This document contains SECRET_DATA that should not be uploaded.")
  ),
];

const labels = [
  "1. Valid PDF File",
  "2. File with Virus",
  "3. File Size Exceeds Limit",
  "4. Invalid File Type",
  "5. Forbidden Content",
];

console.log("=== File Upload Processing Pipeline System ===\n");

for (let i = 0; i < scenarios.length; i++) {
  console.log(`--- ${labels[i]} ---`);
  virusScanner.handle(scenarios[i]);
  printResult(scenarios[i]);
}
