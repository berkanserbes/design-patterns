namespace ChainOfResponsibilityDesignPattern.Example2.Handlers;

public class FileTypeValidatorHandler : BaseFileHandler
{
    private readonly List<string> _allowedExtensions = new() 
    { 
        ".pdf", ".doc", ".docx", ".txt", ".jpg", ".jpeg", ".png", ".gif" 
    };

    public override void Handle(FileUploadRequest request)
    {
        if (!_allowedExtensions.Contains(request.FileExtension.ToLower()))
        {
            request.IsValid = false;
            request.ValidationMessages.Add($"File type '{request.FileExtension}' is not allowed. Allowed: {string.Join(", ", _allowedExtensions)}");
            return; // Stop the chain
        }
        
        // Pass to next handler
        base.Handle(request);
    }
}
