package behavioral.chainofresponsibility.example2;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Chain of Responsibility - File Upload Validation ===\n");

        IFileHandler chain = buildChain();

        System.out.println("--- Test 1: Valid PDF ---");
        FileUploadRequest validPdf = new FileUploadRequest("report.pdf", ".pdf",
                500 * 1024, "This is a normal PDF document content.".getBytes());
        chain.handle(validPdf);
        printResult(validPdf);

        chain = buildChain();
        System.out.println("--- Test 2: File with Virus ---");
        FileUploadRequest virusFile = new FileUploadRequest("infected.txt", ".txt",
                1024, "Normal text VIRUS embedded here.".getBytes());
        chain.handle(virusFile);
        printResult(virusFile);

        chain = buildChain();
        System.out.println("--- Test 3: File Too Large ---");
        FileUploadRequest largeFile = new FileUploadRequest("bigfile.jpg", ".jpg",
                15 * 1024 * 1024, "image data".getBytes());
        chain.handle(largeFile);
        printResult(largeFile);

        chain = buildChain();
        System.out.println("--- Test 4: Invalid File Type ---");
        FileUploadRequest invalidType = new FileUploadRequest("script.exe", ".exe",
                1024, "binary data".getBytes());
        chain.handle(invalidType);
        printResult(invalidType);

        chain = buildChain();
        System.out.println("--- Test 5: Forbidden Content ---");
        FileUploadRequest forbidden = new FileUploadRequest("data.txt", ".txt",
                1024, "Some text with CONFIDENTIAL_LEAK inside.".getBytes());
        chain.handle(forbidden);
        printResult(forbidden);
    }

    private static IFileHandler buildChain() {
        IFileHandler fileTypeValidator = new FileTypeValidatorHandler();
        IFileHandler fileSizeValidator = new FileSizeValidatorHandler();
        IFileHandler virusScanner = new VirusScannerHandler();
        IFileHandler contentValidator = new ContentValidatorHandler();
        fileTypeValidator.setNext(fileSizeValidator).setNext(virusScanner).setNext(contentValidator);
        return fileTypeValidator;
    }

    private static void printResult(FileUploadRequest request) {
        System.out.println("  Result: " + (request.isValid() ? "VALID - File uploaded successfully." : "INVALID - Upload rejected."));
        for (String msg : request.getValidationMessages()) {
            System.out.println("    - " + msg);
        }
        System.out.println();
    }
}
