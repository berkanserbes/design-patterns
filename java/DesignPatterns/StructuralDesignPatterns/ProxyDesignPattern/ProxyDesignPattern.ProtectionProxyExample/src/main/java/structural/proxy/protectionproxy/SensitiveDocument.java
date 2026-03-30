package structural.proxy.protectionproxy;

public class SensitiveDocument implements IDocument {
    private final String name;
    private String content;

    public SensitiveDocument(String name, String content) {
        this.name = name;
        this.content = content;
    }

    @Override
    public void read() {
        System.out.println("[Document] Reading '" + name + "':");
        System.out.println("[Document] Content: " + content);
    }

    @Override
    public void write(String content) {
        this.content = content;
        System.out.println("[Document] Content updated to: " + content);
    }

    @Override
    public void delete() {
        System.out.println("[Document] '" + name + "' has been deleted!");
        content = "";
    }
}
