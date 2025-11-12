using ChainOfResponsibilityDesignPattern.Example2;
using ChainOfResponsibilityDesignPattern.Example2.Handlers;

Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║       File Upload Processing Pipeline System              ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

// Create the chain of responsibility
var virusScanner = new VirusScannerHandler();
var fileSizeValidator = new FileSizeValidatorHandler();
var fileTypeValidator = new FileTypeValidatorHandler();
var contentValidator = new ContentValidatorHandler();

// Setup the chain
virusScanner
    .SetNext(fileSizeValidator)
    .SetNext(fileTypeValidator)
    .SetNext(contentValidator);

while (true)
{
    Console.WriteLine("\nTest Scenarios:");
    Console.WriteLine("1. Valid PDF File");
    Console.WriteLine("2. File with Virus");
    Console.WriteLine("3. File Size Exceeds Limit");
    Console.WriteLine("4. Invalid File Type");
    Console.WriteLine("5. Forbidden Content");
    Console.WriteLine("0. Exit");
    Console.Write("\nSelect a scenario (0-5): ");
    
    var choice = Console.ReadLine();
    
    if (choice == "0")
    {
        Console.WriteLine("\nGoodbye!");
        break;
    }

    Console.WriteLine();
    
    switch (choice)
    {
        case "1":
            TestValidFile(virusScanner);
            break;
        case "2":
            TestVirusFile(virusScanner);
            break;
        case "3":
            TestLargeFile(virusScanner);
            break;
        case "4":
            TestInvalidFileType(virusScanner);
            break;
        case "5":
            TestForbiddenContent(virusScanner);
            break;
        default:
            Console.WriteLine("Invalid choice! Please select 0-5.");
            break;
    }
    
    if (choice is "1" or "2" or "3" or "4" or "5")
    {
        Console.WriteLine("\n" + new string('─', 60));
    }
}

static void TestValidFile(IFileHandler handler)
{
    Console.WriteLine("Testing: Valid PDF File\n");
    
    var file = new FileUploadRequest(
        fileName: "document.pdf",
        fileExtension: ".pdf",
        fileSizeInBytes: 2 * 1024 * 1024,
        fileContent: System.Text.Encoding.UTF8.GetBytes("This is a valid PDF document content.")
    );

    handler.Handle(file);
    PrintResult(file);
}

static void TestVirusFile(IFileHandler handler)
{
    Console.WriteLine("Testing: File with Virus\n");
    
    var file = new FileUploadRequest(
        fileName: "infected.doc",
        fileExtension: ".doc",
        fileSizeInBytes: 1 * 1024 * 1024,
        fileContent: System.Text.Encoding.UTF8.GetBytes("This file contains a VIRUS signature.")
    );

    handler.Handle(file);
    PrintResult(file);
}

static void TestLargeFile(IFileHandler handler)
{
    Console.WriteLine("Testing: File Size Exceeds Limit\n");
    
    var file = new FileUploadRequest(
        fileName: "large_video.mp4",
        fileExtension: ".mp4",
        fileSizeInBytes: 15 * 1024 * 1024,
        fileContent: System.Text.Encoding.UTF8.GetBytes("Large video content...")
    );

    handler.Handle(file);
    PrintResult(file);
}

static void TestInvalidFileType(IFileHandler handler)
{
    Console.WriteLine("Testing: Invalid File Type\n");
    
    var file = new FileUploadRequest(
        fileName: "script.exe",
        fileExtension: ".exe",
        fileSizeInBytes: 500 * 1024,
        fileContent: System.Text.Encoding.UTF8.GetBytes("Executable content...")
    );

    handler.Handle(file);
    PrintResult(file);
}

static void TestForbiddenContent(IFileHandler handler)
{
    Console.WriteLine("Testing: Forbidden Content\n");
    
    var file = new FileUploadRequest(
        fileName: "report.txt",
        fileExtension: ".txt",
        fileSizeInBytes: 100 * 1024,
        fileContent: System.Text.Encoding.UTF8.GetBytes("This document contains SECRET_DATA that should not be uploaded.")
    );

    handler.Handle(file);
    PrintResult(file);
}

static void PrintResult(FileUploadRequest request)
{
    Console.WriteLine($"File: {request.FileName} ({request.GetFileSizeInMB():F2} MB)");
    
    if (request.IsValid)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Status: ✓ APPROVED - File validated successfully!");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Status: ✗ REJECTED");
        Console.WriteLine("\nReasons:");
        foreach (var message in request.ValidationMessages)
        {
            Console.WriteLine($"  • {message}");
        }
        Console.ResetColor();
    }
}
