package behavioral.command.example1;

public class DeleteTextCommand implements ICommand {
    private final TextEditor editor;
    private final int length;
    private String deletedText;

    public DeleteTextCommand(TextEditor editor, int length) {
        this.editor = editor;
        this.length = length;
    }

    @Override
    public void execute() {
        String content = editor.getContent();
        int start = Math.max(0, content.length() - length);
        deletedText = content.substring(start);
        editor.deleteText(length);
    }

    @Override
    public void unexecute() { editor.appendText(deletedText); }
}
