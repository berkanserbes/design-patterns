package behavioral.command.example1;

public class InsertTextCommand implements ICommand {
    private final TextEditor editor;
    private final String text;

    public InsertTextCommand(TextEditor editor, String text) {
        this.editor = editor;
        this.text = text;
    }

    @Override
    public void execute() { editor.appendText(text); }

    @Override
    public void unexecute() { editor.deleteText(text.length()); }
}
