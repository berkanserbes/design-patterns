package creational.prototype.example1.models;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class DocumentMetadata {
    public String author  = "";
    public String version = "1.0";
    public List<String> tags = new ArrayList<>();
    public Map<String, String> customProperties = new HashMap<>();
    public int pageCount = 1;

    @Override
    public String toString() {
        return "Author: " + author + ", Version: " + version +
               ", Pages: " + pageCount + ", Tags: [" + String.join(", ", tags) + "]";
    }
}
