namespace ChainOfResponsibilityDesignPattern.Example2;

public interface IFileHandler
{
    IFileHandler SetNext(IFileHandler handler);
    void Handle(FileUploadRequest request);
}
