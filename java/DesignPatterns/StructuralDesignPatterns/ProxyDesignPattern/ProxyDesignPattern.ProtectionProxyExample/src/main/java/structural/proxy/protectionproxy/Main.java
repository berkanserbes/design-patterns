package structural.proxy.protectionproxy;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== PROTECTION PROXY PATTERN DEMO ===\n");

        SensitiveDocument document = new SensitiveDocument("Financial Report", "Q4 Revenue: $1,000,000");

        User viewer = new User("John", Role.VIEWER);
        User editor = new User("Jane", Role.EDITOR);
        User admin = new User("Bob", Role.ADMIN);

        System.out.println("--- Testing VIEWER Access ---\n");
        IDocument viewerProxy = new DocumentProxy(document, viewer);
        viewerProxy.read();
        viewerProxy.write("Hacked content!");
        viewerProxy.delete();

        System.out.println("\n--- Testing EDITOR Access ---\n");
        IDocument editorProxy = new DocumentProxy(document, editor);
        editorProxy.read();
        editorProxy.write("Q4 Revenue: $1,500,000");
        editorProxy.delete();

        System.out.println("\n--- Testing ADMIN Access ---\n");
        IDocument adminProxy = new DocumentProxy(document, admin);
        adminProxy.read();
        adminProxy.write("CONFIDENTIAL");
        adminProxy.delete();

        System.out.println("\n=== SUMMARY ===");
        System.out.println("Viewer: Could only READ");
        System.out.println("Editor: Could READ and WRITE");
        System.out.println("Admin:  Could READ, WRITE and DELETE");
    }
}
