package behavioral.chainofresponsibility.example2;

public class VirusScannerHandler extends BaseFileHandler {
    @Override
    public void handle(FileUploadRequest request) {
        System.out.println("[VirusScanner] Scanning file: " + request.getFileName());
        String content = new String(request.getFileContent());
        if (content.contains("MALWARE") || content.contains("VIRUS") || content.contains("TROJAN")) {
            request.setValid(false);
            request.addMessage("Virus scan failed: Malicious content detected.");
            System.out.println("  Virus scan FAILED - malicious content detected!");
            return;
        }
        request.addMessage("Virus scan passed: No threats detected.");
        System.out.println("  Virus scan PASSED.");
        super.handle(request);
    }
}
