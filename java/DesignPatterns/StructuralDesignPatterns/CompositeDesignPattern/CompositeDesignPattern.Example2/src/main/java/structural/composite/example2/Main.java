package structural.composite.example2;

public class Main {
    public static void main(String[] args) {
        Folder rootFolder = new Folder("root", "/root");
        Folder srcFolder = new Folder("src", "/root/src");

        rootFolder.addItem(srcFolder);

        FileItem mainFile = new FileItem("main.cs", "/root/src/main.cs", ".cs", 1024);
        srcFolder.addItem(mainFile);

        FileItem readmeFile = new FileItem("README.md", "/root/README.md", ".md", 2048);
        rootFolder.addItem(readmeFile);

        System.out.println("Total size of root folder: " + rootFolder.getSize() + " bytes");
        rootFolder.displayItems();
    }
}
