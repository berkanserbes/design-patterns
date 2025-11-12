namespace ChainOfResponsibilityDesignPattern.Example2;

public abstract class BaseFileHandler : IFileHandler
{
    private IFileHandler? _nextHandler;

    public IFileHandler SetNext(IFileHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void Handle(FileUploadRequest request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}
