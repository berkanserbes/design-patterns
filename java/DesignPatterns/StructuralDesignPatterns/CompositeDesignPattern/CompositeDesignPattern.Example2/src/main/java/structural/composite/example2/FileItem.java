package structural.composite.example2;

public class FileItem extends IFileSystemItem {
    public double size;
    public String extension;

    public FileItem(String name, String path, String extension, double size) {
        super(name, path);
        this.extension = extension;
        this.size = size;
    }

    @Override
    public double getSize() { return size; }
}
