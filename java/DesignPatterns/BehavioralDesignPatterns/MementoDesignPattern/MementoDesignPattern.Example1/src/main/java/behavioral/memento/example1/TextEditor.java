package behavioral.memento.example1;

public class TextEditor {
    private final String documentId;
    private String content = "";
    private String fontName = "Arial";
    private int fontSize = 12;
    private int cursorPosition = 0;

    public TextEditor(String documentId) { this.documentId = documentId; }

    public void type(String text) {
        content += text;
        cursorPosition = content.length();
    }

    public void changeFont(String fontName, int fontSize) {
        this.fontName = fontName;
        this.fontSize = fontSize;
    }

    public void moveCursor(int position) {
        cursorPosition = Math.min(Math.max(0, position), content.length());
    }

    public DocumentSnapshot createSnapshot(String name) {
        return new DocumentSnapshot(documentId, content, fontName, fontSize, cursorPosition, name);
    }

    public void restoreFromSnapshot(DocumentSnapshot snapshot) {
        this.content = snapshot.getContent();
        this.fontName = snapshot.getFontName();
        this.fontSize = snapshot.getFontSize();
        this.cursorPosition = snapshot.getCursorPosition();
    }

    public void displayStatus() {
        System.out.println("  Document: " + documentId);
        System.out.println("  Content: \"" + content + "\"");
        System.out.println("  Font: " + fontName + " " + fontSize + "pt");
        System.out.println("  Cursor: " + cursorPosition);
    }
}
