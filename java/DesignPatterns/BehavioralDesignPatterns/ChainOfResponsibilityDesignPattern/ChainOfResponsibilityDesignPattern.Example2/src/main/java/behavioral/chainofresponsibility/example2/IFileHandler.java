package behavioral.chainofresponsibility.example2;

public interface IFileHandler {
    IFileHandler setNext(IFileHandler handler);
    void handle(FileUploadRequest request);
}
