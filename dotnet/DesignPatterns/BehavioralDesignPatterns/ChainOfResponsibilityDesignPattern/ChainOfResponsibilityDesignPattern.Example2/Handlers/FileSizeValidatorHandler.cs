namespace ChainOfResponsibilityDesignPattern.Example2.Handlers;

public class FileSizeValidatorHandler : BaseFileHandler
{
    private const long MAX_FILE_SIZE_BYTES = 10 * 1024 * 1024; // 10 MB

    public override void Handle(FileUploadRequest request)
    {
        if (request.FileSizeInBytes > MAX_FILE_SIZE_BYTES)
        {
            request.IsValid = false;
            request.ValidationMessages.Add($"File size exceeds maximum allowed size of {MAX_FILE_SIZE_BYTES / (1024 * 1024)} MB.");
            return; // Stop the chain
        }
        
        // Pass to next handler
        base.Handle(request);
    }
}
