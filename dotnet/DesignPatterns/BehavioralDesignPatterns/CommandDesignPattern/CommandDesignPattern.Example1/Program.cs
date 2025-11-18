using CommandDesignPattern.Example1;

Console.WriteLine("=== Command Design Pattern - Text Editor with Undo/Redo ===\n");

var editor = new TextEditor();
var commandManager = new CommandManager();

// Execute commands
commandManager.ExecuteCommand(new InsertTextCommand(editor, "Hello "));
commandManager.ExecuteCommand(new InsertTextCommand(editor, "World!"));
commandManager.ExecuteCommand(new InsertTextCommand(editor, " This is a test."));
editor.DisplayContent();

// Delete and undo
commandManager.ExecuteCommand(new DeleteTextCommand(editor, 15));
editor.DisplayContent();

commandManager.Undo();
editor.DisplayContent();

// Redo
commandManager.Redo();
editor.DisplayContent();
