package behavioral.chainofresponsibility.example2;

public class FileSizeValidatorHandler extends BaseFileHandler {
    private static final long MAX_SIZE = 10L * 1024 * 1024; // 10MB

    @Override
    public void handle(FileUploadRequest request) {
        System.out.println("[FileSizeValidator] Checking file size: " + (request.getFileSizeInBytes() / 1024) + " KB");
        if (request.getFileSizeInBytes() > MAX_SIZE) {
            request.setValid(false);
            request.addMessage("File size rejected: " + (request.getFileSizeInBytes() / (1024 * 1024)) + " MB exceeds the 10 MB limit.");
            System.out.println("  File size check FAILED.");
            return;
        }
        request.addMessage("File size is within limit.");
        System.out.println("  File size check PASSED.");
        super.handle(request);
    }
}
