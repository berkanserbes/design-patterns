namespace ChainOfResponsibilityDesignPattern.Example2;

public class FileUploadRequest
{
    public string FileName { get; set; }
    public string FileExtension { get; set; }
    public long FileSizeInBytes { get; set; }
    public byte[] FileContent { get; set; }
    public bool IsValid { get; set; } = true;
    public List<string> ValidationMessages { get; set; } = new();

    public FileUploadRequest(string fileName, string fileExtension, long fileSizeInBytes, byte[] fileContent)
    {
        FileName = fileName;
        FileExtension = fileExtension;
        FileSizeInBytes = fileSizeInBytes;
        FileContent = fileContent;
    }

    public double GetFileSizeInMB() => FileSizeInBytes / (1024.0 * 1024.0);
}
