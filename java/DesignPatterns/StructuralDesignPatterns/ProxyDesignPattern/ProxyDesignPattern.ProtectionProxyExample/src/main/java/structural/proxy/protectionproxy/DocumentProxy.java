package structural.proxy.protectionproxy;

public class DocumentProxy implements IDocument {
    private final SensitiveDocument realDocument;
    private final User user;

    public DocumentProxy(SensitiveDocument document, User user) {
        this.realDocument = document;
        this.user = user;
        System.out.println("[Proxy] Access granted to user '" + user.getName() + "' with role '" + user.getRole() + "'");
    }

    @Override
    public void read() {
        System.out.println("[Proxy] User '" + user.getName() + "' is reading...");
        realDocument.read();
    }

    @Override
    public void write(String content) {
        if (user.getRole() == Role.VIEWER) {
            System.out.println("[Proxy] ACCESS DENIED: '" + user.getName() + "' (Viewer) cannot write!");
            return;
        }
        System.out.println("[Proxy] User '" + user.getName() + "' is writing...");
        realDocument.write(content);
    }

    @Override
    public void delete() {
        if (user.getRole() != Role.ADMIN) {
            System.out.println("[Proxy] ACCESS DENIED: '" + user.getName() + "' (" + user.getRole() + ") cannot delete!");
            return;
        }
        System.out.println("[Proxy] User '" + user.getName() + "' is deleting...");
        realDocument.delete();
    }
}
