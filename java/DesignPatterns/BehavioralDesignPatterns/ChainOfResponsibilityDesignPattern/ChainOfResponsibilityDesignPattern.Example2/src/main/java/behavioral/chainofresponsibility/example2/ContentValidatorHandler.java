package behavioral.chainofresponsibility.example2;

public class ContentValidatorHandler extends BaseFileHandler {
    @Override
    public void handle(FileUploadRequest request) {
        System.out.println("[ContentValidator] Validating content of: " + request.getFileName());
        String content = new String(request.getFileContent());
        if (content.contains("CONFIDENTIAL_LEAK") || content.contains("SECRET_DATA") || content.contains("BANNED_CONTENT")) {
            request.setValid(false);
            request.addMessage("Content validation failed: Forbidden content detected.");
            System.out.println("  Content validation FAILED.");
            return;
        }
        request.addMessage("Content validation passed.");
        System.out.println("  Content validation PASSED.");
        super.handle(request);
    }
}
