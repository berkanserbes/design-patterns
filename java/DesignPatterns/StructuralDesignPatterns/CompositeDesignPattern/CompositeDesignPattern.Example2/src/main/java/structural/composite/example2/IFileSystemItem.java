package structural.composite.example2;

import java.time.LocalDateTime;

public abstract class IFileSystemItem {
    public String name;
    public String path;
    public LocalDateTime createdDate;

    public IFileSystemItem(String name, String path) {
        this.name = name;
        this.path = path;
        this.createdDate = LocalDateTime.now();
    }

    public abstract double getSize();
}
