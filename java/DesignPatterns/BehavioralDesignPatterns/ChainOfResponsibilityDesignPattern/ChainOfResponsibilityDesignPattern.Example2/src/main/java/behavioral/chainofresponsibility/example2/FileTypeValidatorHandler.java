package behavioral.chainofresponsibility.example2;

import java.util.Set;

public class FileTypeValidatorHandler extends BaseFileHandler {
    private static final Set<String> ALLOWED_EXTENSIONS = Set.of(".pdf", ".doc", ".docx", ".txt", ".jpg", ".jpeg", ".png", ".gif");

    @Override
    public void handle(FileUploadRequest request) {
        System.out.println("[FileTypeValidator] Checking file type: " + request.getFileExtension());
        if (!ALLOWED_EXTENSIONS.contains(request.getFileExtension().toLowerCase())) {
            request.setValid(false);
            request.addMessage("File type rejected: '" + request.getFileExtension() + "' is not allowed.");
            System.out.println("  File type check FAILED.");
            return;
        }
        request.addMessage("File type '" + request.getFileExtension() + "' is allowed.");
        System.out.println("  File type check PASSED.");
        super.handle(request);
    }
}
