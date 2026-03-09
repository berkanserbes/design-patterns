using MementoDesignPattern.Example1;

WorkspaceManager workspaceManager = new();

var mainDocument = new TextEditor("Program.cs");
var readmeDocument = new TextEditor("README.md");

workspaceManager.RegisterDocument(mainDocument);
workspaceManager.RegisterDocument(readmeDocument);

DocumentHistory mainHistory = workspaceManager.GetDocumentHistory(mainDocument.DocumentId);
DocumentHistory readmeHistory = workspaceManager.GetDocumentHistory(readmeDocument.DocumentId);

Console.WriteLine("========== Document 1: Program.cs ==========\n");

mainHistory.Backup();
mainDocument.Type("using System;");

mainHistory.Backup();
mainDocument.Type("""
public class Main 
{
    Console.WriteLine("Hello World");
}
""");

mainHistory.Backup();
mainDocument.ChangeFont("Consolas", 14);

mainDocument.DisplayStatus();

Console.WriteLine("\n--- Undo (revert font change) ---");
mainHistory.Undo();
mainDocument.DisplayStatus();

Console.WriteLine("\n--- Undo (revert class block) ---");
mainHistory.Undo();
mainDocument.DisplayStatus();

Console.WriteLine("\n--- Redo (re-apply class block) ---");
mainHistory.Redo();
mainDocument.DisplayStatus();

Console.WriteLine("\n========== Document 2: README.md ==========\n");

readmeHistory.Backup();
readmeDocument.Type("# Memento Design Pattern");

readmeHistory.Backup();
readmeDocument.Type("\nThis project demonstrates the Memento pattern.");
readmeDocument.DisplayStatus();

Console.WriteLine("\n--- Undo on README ---");
readmeHistory.Undo();
readmeDocument.DisplayStatus();