package behavioral.command.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Command Pattern - Text Editor Undo/Redo ===\n");

        TextEditor editor = new TextEditor();
        CommandManager manager = new CommandManager();

        System.out.println("Insert \"Hello \"");
        manager.executeCommand(new InsertTextCommand(editor, "Hello "));
        editor.displayContent();

        System.out.println("Insert \"World!\"");
        manager.executeCommand(new InsertTextCommand(editor, "World!"));
        editor.displayContent();

        System.out.println("Insert \" This is a test.\"");
        manager.executeCommand(new InsertTextCommand(editor, " This is a test."));
        editor.displayContent();

        System.out.println("Delete last 16 characters");
        manager.executeCommand(new DeleteTextCommand(editor, 16));
        editor.displayContent();

        System.out.println("Undo delete");
        manager.undo();
        editor.displayContent();

        System.out.println("Redo delete");
        manager.redo();
        editor.displayContent();
    }
}
