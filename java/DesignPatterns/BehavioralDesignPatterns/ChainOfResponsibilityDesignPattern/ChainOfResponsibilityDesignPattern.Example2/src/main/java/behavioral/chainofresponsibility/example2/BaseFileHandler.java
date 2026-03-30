package behavioral.chainofresponsibility.example2;

public abstract class BaseFileHandler implements IFileHandler {
    private IFileHandler nextHandler;

    @Override
    public IFileHandler setNext(IFileHandler handler) {
        this.nextHandler = handler;
        return handler;
    }

    @Override
    public void handle(FileUploadRequest request) {
        if (nextHandler != null) {
            nextHandler.handle(request);
        }
    }
}
