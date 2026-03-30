package behavioral.command.example1;

public class TextEditor {
    private StringBuilder content = new StringBuilder();

    public void appendText(String text) {
        content.append(text);
    }

    public void deleteText(int length) {
        if (length > content.length()) length = content.length();
        content.delete(content.length() - length, content.length());
    }

    public String getContent() { return content.toString(); }

    public void displayContent() {
        System.out.println("Content: \"" + content + "\"");
    }
}
