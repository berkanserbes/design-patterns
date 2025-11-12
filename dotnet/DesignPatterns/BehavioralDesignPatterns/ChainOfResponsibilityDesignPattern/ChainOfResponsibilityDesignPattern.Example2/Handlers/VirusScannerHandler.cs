namespace ChainOfResponsibilityDesignPattern.Example2.Handlers;

public class VirusScannerHandler : BaseFileHandler
{
    // Simulated virus signatures
    private readonly List<string> _virusSignatures = new() { "MALWARE", "VIRUS", "TROJAN" };

    public override void Handle(FileUploadRequest request)
    {
        // Simulate virus scanning by checking file content
        string contentAsString = System.Text.Encoding.UTF8.GetString(request.FileContent);
        
        bool virusDetected = _virusSignatures.Any(signature => 
            contentAsString.Contains(signature, StringComparison.OrdinalIgnoreCase));

        if (virusDetected)
        {
            request.IsValid = false;
            request.ValidationMessages.Add("Virus detected! File rejected.");
            return; // Stop the chain
        }
        
        // Pass to next handler
        base.Handle(request);
    }
}
