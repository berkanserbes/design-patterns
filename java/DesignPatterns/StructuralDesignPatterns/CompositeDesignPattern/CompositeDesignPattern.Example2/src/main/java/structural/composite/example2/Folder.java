package structural.composite.example2;

import java.util.ArrayList;
import java.util.List;

public class Folder extends IFileSystemItem {
    private final List<IFileSystemItem> items = new ArrayList<>();

    public Folder(String name, String path) {
        super(name, path);
    }

    @Override
    public double getSize() {
        return items.stream().mapToDouble(IFileSystemItem::getSize).sum();
    }

    public void addItem(IFileSystemItem item) { items.add(item); }
    public void removeItem(IFileSystemItem item) { items.remove(item); }

    public void displayItems() {
        for (IFileSystemItem item : items) {
            if (item instanceof Folder folder) {
                System.out.println("Folder: " + folder.name + ", Path: " + folder.path +
                    ", Created: " + folder.createdDate + ", Size: " + folder.getSize() + " bytes");
                folder.displayItems();
            } else if (item instanceof FileItem file) {
                System.out.println("File: " + file.name + ", Path: " + file.path +
                    ", Created: " + file.createdDate + ", Size: " + file.getSize() + " bytes");
            }
        }
    }
}
