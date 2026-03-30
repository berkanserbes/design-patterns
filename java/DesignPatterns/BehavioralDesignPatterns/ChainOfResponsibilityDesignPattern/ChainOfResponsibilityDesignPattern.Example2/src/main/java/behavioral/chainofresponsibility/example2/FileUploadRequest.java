package behavioral.chainofresponsibility.example2;

import java.util.ArrayList;
import java.util.List;

public class FileUploadRequest {
    private final String fileName;
    private final String fileExtension;
    private final long fileSizeInBytes;
    private final byte[] fileContent;
    private boolean isValid = true;
    private final List<String> validationMessages = new ArrayList<>();

    public FileUploadRequest(String fileName, String fileExtension, long fileSizeInBytes, byte[] fileContent) {
        this.fileName = fileName;
        this.fileExtension = fileExtension;
        this.fileSizeInBytes = fileSizeInBytes;
        this.fileContent = fileContent;
    }

    public String getFileName() { return fileName; }
    public String getFileExtension() { return fileExtension; }
    public long getFileSizeInBytes() { return fileSizeInBytes; }
    public byte[] getFileContent() { return fileContent; }
    public boolean isValid() { return isValid; }
    public void setValid(boolean valid) { isValid = valid; }
    public List<String> getValidationMessages() { return validationMessages; }
    public void addMessage(String message) { validationMessages.add(message); }
}
