package creational.prototype.example1.models.abstracts;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.databind.ObjectMapper;
import creational.prototype.example1.models.DocumentMetadata;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.UUID;

public abstract class DocumentBase implements IDocumentPrototype<DocumentBase>, Cloneable {
    public String           id;
    public String           title    = "";
    public String           content  = "";
    public LocalDateTime    createdDate;
    public LocalDateTime    lastModified;
    public DocumentMetadata metadata = new DocumentMetadata();

    protected DocumentBase() {
        this.id          = UUID.randomUUID().toString();
        this.createdDate = LocalDateTime.now();
        this.lastModified = LocalDateTime.now();
    }

    // Shallow clone: reference-type fields share the same reference
    @Override
    public DocumentBase clone() {
        try {
            DocumentBase cloned = (DocumentBase) super.clone();
            cloned.id           = UUID.randomUUID().toString();
            cloned.createdDate  = LocalDateTime.now();
            cloned.lastModified = LocalDateTime.now();
            return cloned;
        } catch (CloneNotSupportedException e) {
            throw new RuntimeException(e);
        }
    }

    // Deep clone via Jackson JSON serialization
    @Override
    public DocumentBase deepClone() {
        try {
            ObjectMapper mapper = new ObjectMapper();
            mapper.findAndRegisterModules(); // support LocalDateTime
            String json = mapper.writeValueAsString(this);
            DocumentBase cloned = mapper.readValue(json, this.getClass());
            cloned.id           = UUID.randomUUID().toString();
            cloned.createdDate  = LocalDateTime.now();
            cloned.lastModified = LocalDateTime.now();
            return cloned;
        } catch (Exception e) {
            throw new RuntimeException("Deep clone failed: " + e.getMessage(), e);
        }
    }

    @JsonIgnore
    @Override
    public String getDocumentInfo() {
        String formatted = createdDate != null
                ? createdDate.format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm"))
                : "N/A";
        return "ID: " + id + ", Title: " + title +
               ", Type: " + getClass().getSimpleName() + ", Created: " + formatted;
    }

    public abstract boolean validateDocument();
}
