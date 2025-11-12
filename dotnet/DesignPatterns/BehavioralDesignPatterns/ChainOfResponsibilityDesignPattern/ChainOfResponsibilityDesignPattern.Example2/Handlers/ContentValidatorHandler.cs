namespace ChainOfResponsibilityDesignPattern.Example2.Handlers;

public class ContentValidatorHandler : BaseFileHandler
{
    private readonly List<string> _forbiddenWords = new() 
    { 
        "CONFIDENTIAL_LEAK", "SECRET_DATA", "BANNED_CONTENT" 
    };

    public override void Handle(FileUploadRequest request)
    {
        // Check file content for forbidden words
        string contentAsString = System.Text.Encoding.UTF8.GetString(request.FileContent);
        
        var foundForbiddenWords = _forbiddenWords
            .Where(word => contentAsString.Contains(word, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (foundForbiddenWords.Any())
        {
            request.IsValid = false;
            request.ValidationMessages.Add($"Forbidden content detected: {string.Join(", ", foundForbiddenWords)}");
            return; // Stop the chain
        }
        
        // Pass to next handler
        base.Handle(request);
    }
}
